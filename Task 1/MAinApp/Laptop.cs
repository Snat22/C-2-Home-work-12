namespace MAinApp;

public class Laptop : Computer
{
    public double Weight { get; set; }


    public double WeightChek()
    {
        return Weight;
        
    }
        public void Info()
        {
        System.Console.WriteLine($"{base.GetAllInfo()}\nWeight = {Weight}");
        }
}

