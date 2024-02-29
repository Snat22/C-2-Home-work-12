namespace MainApp;

public class CargoCar :Car
{
    public int Weight { get; set; }
    public CargoCar(int heshcode,string model,double fuel,int seats,int power,int speed,string color,int price,int weight) :base(heshcode,model,fuel,seats,power,speed,color,price)
    {
        Weight = weight;
        System.Console.WriteLine("Cargo Car created: ");
    }

    public void CargoCarInfo()
    {
        System.Console.WriteLine($"{base.GetInfo()}\nWeight: {Weight}k");
    }

}
