public class Modules
{
    public int Result;
    public String Modual_Title; 
       
    public Modules(String ModTitle, int Res)//add modual and result
    {
        Modual_Title = ModTitle;
        Result = Res;
    }
    
    public String Found()// return modual title to be used in adding results to moduals.
    {
        return Modual_Title;
    }
}
