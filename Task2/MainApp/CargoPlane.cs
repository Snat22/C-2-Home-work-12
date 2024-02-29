namespace MainApp;

public class CargoPlane :AirPlane
{
    public double LoadCapacity { get; set; }
    public CargoPlane(int heshcode,string model,double fuel,int seats,int power,int speed,string company,int price,double loadcapacity) :base(heshcode,model,fuel,seats,power,speed,company,price)
    {
        LoadCapacity = loadcapacity;
        System.Console.WriteLine("Cargoplane created: ");
    }

    public void GetCargoPlaneInfo()
    {
        if (LoadCapacity > 3000)
            Fuel += LoadCapacity / 100;

            System.Console.WriteLine($"{base.GetInfo()} \nLoad Capacity: {LoadCapacity} ");
    }
}
