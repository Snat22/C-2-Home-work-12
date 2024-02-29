namespace MAinApp;

public class Computer
{
    public int Ram { get; set; }  
    public int Storage { get; set; }
    public string KeyBoard { get; set; }

    public Computer()
    {}


    public void AddRam()
    {
        Ram = Convert.ToInt32(Console.ReadLine()); 
        System.Console.WriteLine("RAM added");       
    }

        public void AddStorage()
    {
        Storage = Convert.ToInt32(Console.ReadLine()); 
        System.Console.WriteLine("RAM added");       
    }

    public string GetAllInfo()
    {
        return $"Ram = {Ram}\nStorage = {Storage}\nKeyboard = {KeyBoard}";
    }

}
