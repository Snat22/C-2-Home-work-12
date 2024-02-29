using System.Drawing;

namespace MainApp;

public class Car :Transport
{
    public string Color { get; set; }

    public Car(int heshcode,string model,double fuel,int seats,int power,int speed,string color,int price) :base(heshcode,model,fuel,seats,power,speed,price)
    {
        Color = color;
    }

    public void AddPower()
    {
        Power += Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Power: +{Power}hp");
        Fuel += Power / 10;
        Price += Power + Power / 10;
    }
    
    public void CarInfo()
    {
        System.Console.WriteLine($"{base.GetInfo()} \nModel:{Model} Color: {Color}");
    }

}
