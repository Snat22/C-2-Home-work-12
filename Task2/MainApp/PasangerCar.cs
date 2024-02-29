namespace MainApp;

public class PasangerCar :Car
{
    public int Door { get; set; }
public PasangerCar(int heshcode,string model,double fuel,int seats,int power,int speed,string color,int price,int door) :base(heshcode,model,fuel,seats,power,speed,color,price)
{
    Door = door;
    System.Console.WriteLine("PasangerCar created: ");
}

public void GetPasangerCArInfo()
{
       System.Console.Write($"{base.GetInfo()} \nDoor: ");

    if (Door < 3)
    {
    System.Console.WriteLine("Coupe");
    }else
    {
        System.Console.WriteLine("Sedan ");
    }
}
}
