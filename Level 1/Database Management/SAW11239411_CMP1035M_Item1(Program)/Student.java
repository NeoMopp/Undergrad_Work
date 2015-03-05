public class Student
{
    public int StudentID;
    public String First_Name;
    public String Surname;
    public char Middle_Initial;
    public String Telephone_Number;
    public Modules[] Modules_Taken = new Modules[4];
    
    public void newStudent()
    {
       StudentID = User.inputInt("Enter Student ID: "); 
       First_Name = User.inputString("Enter Student's First Name: ");
       Surname = User.inputString("Enter Student's Surname: ");
       Middle_Initial = User.inputChar("Enter Student's Middle Initial: ");
       
       //loop to check and see that all the characters are numbers
       while (true)
       {
            Telephone_Number = User.inputString("Enter Student's Telephone Number: ");
            int x = 0;
            for (int i = 0; i < Telephone_Number.length(); i++)
            {
                if (Telephone_Number.charAt(i) == '0')
                {
                        x++;
                } 
                
                if (Telephone_Number.charAt(i) == '1')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '2')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '3')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '4')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '5')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '6')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '7')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '8')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '9')
                {
                        x++;
                }
            }
            
            if (x == Telephone_Number.length()) 
            {
                break;
            }  
       }       
   }
   
   public void newModule()//allows for modual to be added
   {
       int i = 0;
       while (true)
       {
        if (Modules_Taken[i] == null)
        {
            String newMod = User.inputString("Enter Modual Title: ");
            Modules add = new Modules(newMod, 0);
            Modules_Taken[i]= add;
            break;
        }
       
        else
        {
            i++;
        }
       }
   }
    
   public void newResult()//allows for a result to be added to a modual
   {
       String CurrentMod = User.inputString("Enter Modual Title: ");
       boolean InExist = true;
       int i = 0;
       while(InExist == true)
        {
            if (i == 4) //error statement to tell users they have entered wrong modual
            {
                User.message("Module isn't available, you may have to add it");
                InExist = false;
            }
            
            String exist = Modules_Taken[i].Found(); 
            if (exist.equals(CurrentMod))//if stsatement to see if modual exists in current context
            {
                System.out.println("Exists");  
                int newRes = User.inputInt("Enter result obtained in this Modual: ");
                Modules update = new Modules(CurrentMod, newRes);
                Modules_Taken[i] = update;
                break;
            }
       
            else
            i++;
            
       }      
    }
    
    public void changeStudentID()
    {
       StudentID = User.inputInt("Enter Student ID: "); 
    }
    
    public void changeFirstName()
    {
       First_Name = User.inputString("Enter Student's First Name: ");
    }
    
    public void changeSurname()
    {
       Surname = User.inputString("Enter Student's Surname: ");
    }
    
    public void changeMiddleInitial()
    {
        Middle_Initial = User.inputChar("Enter Student's Middle Initial: ");
    }
    
    public void changeTelephoneNumber()
    {
        //loop to check and see that all the characters are numbers
       while (true)
       {
            Telephone_Number = User.inputString("Enter Student's Telephone Number: ");
            int x = 0;
            for (int i = 0; i < Telephone_Number.length(); i++)
            {
                if (Telephone_Number.charAt(i) == '0')
                {
                        x++;
                } 
                
                if (Telephone_Number.charAt(i) == '1')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '2')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '3')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '4')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '5')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '6')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '7')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '8')
                {
                        x++;
                }
                
                if (Telephone_Number.charAt(i) == '9')
                {
                        x++;
                }
            }
            
            if (x == Telephone_Number.length()) 
            {
                break;
            }  
       }
    }
}