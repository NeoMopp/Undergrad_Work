import javax.swing.JOptionPane;

/* Class: User ***************************************************************/
/**
 * Simple dialog-based input-output for basic data types.<p>
 * All data and methods are static so class is declared abstract.<p>
 * All input operations read strings and convert to target type, with simple
 * error trapping/tracking for format conversion errors.
 * 
 * @author Paul McCard 
 * @modified by: John C. Murray
 * @version 30/09/04
 * @revision 10/10/10
 */
public abstract class User
{
    static final String version = "30/09/04";
    static boolean err = false;
    static String errRawInput;
    static String errDescript;
    
    /**
     * Display a message in a dialog box - NB error status always false
     * @param  msg  message to be displayed
     */    
    public static void message (String msg)
    {
        JOptionPane.showMessageDialog(null, msg);
        err = false;
    }
    
    /**
     * Display a prompt and read an int value
     * @param prompt prompt to be displayed
     * @return value input by user - if invalid format, error flag is set and zero returned
     */    
    public static int inputInt (String prompt)
    {
        String raw;
        int value;

        raw = JOptionPane.showInputDialog(null, prompt);
        err = false;

        // workround in case Cancel pressed
        if (raw == null)
        {
            raw =   "";
        }

        try
        {
            value = Integer.parseInt(raw);
        }
        catch (NumberFormatException exception)
        {
            err = true;
            errRawInput = raw;
            errDescript = "Not a valid integer";
            value = 0;
        }
        return value;
    }
        
    /**
     * Display a prompt and read a float value
     * @param  prompt   prompt to be displayed
     * @return      value input by user - if invalid format, error flag is set and 0.0F returned
     */    
    public static float inputFloat (String prompt)
    {
        String raw;
        float value;

        raw = JOptionPane.showInputDialog(null, prompt);
        err = false;

        // workround in case Cancel pressed
        if (raw == null)
        {
            raw = "";
        }

        try
        {
            value = Float.parseFloat(raw);
        }
        catch (NumberFormatException exception)
        {
            err = true;
            errRawInput = raw;
            errDescript = "Not a valid decimal number";
            value = 0.0F;
        }
        return value;
    }

    /**
     * Display a prompt and read a String
     * @param  prompt   prompt to be displayed
     * @return      string input by user, possibly zero length, never null
     *          - NB error is always false on return
     */    
    public static String inputString (String prompt)
    {
        String value;
        value = JOptionPane.showInputDialog(null, prompt);
        // workround in case Cancel pressed
        if (value == null)
        {
            value = "";
        }
        err = false;
        return value;
    }

    /**
     * Display a prompt and read a single character
     * @param  prompt   prompt to be displayed
     * @return      value input by user - if invalid format i.e. more or
     * less than a single character, error flag is set and a space character returned
     */    
    public static char inputChar (String prompt)
    {
        String raw;
        char value;
        raw = JOptionPane.showInputDialog(null, prompt);
    
        // workround in case Cancel pressed
        if (raw == null)
        {
            raw = "";
        }
    
        if (raw.length() == 1)
        {
            value = raw.charAt(0);
            err = false;
        }
        else
        {   
            value = ' ';
            err = true;
            errRawInput = raw;
            errDescript = "Must be a single character";     
        }
        return value;
    }
    
    /**
     * Indicates whether a format error occurred on last operation
     * @return      error status
     */    
    public static boolean error ()
    {
        return err;
    }
    
    /**
     * Returns input string which yielded most recent error status - NB 
     * meaningful only when error() is true
     * @return      raw string input by user
     */    
    public static String errorInput ()
    {
        return errRawInput;
    }
    
    /**
     * Returns a simle description of nature of most recent error status - NB 
     * meaningful only when error() is true
     * @return      error message
     */    
    public static String errorMsg ()
    {
        return errDescript;
    }
}
