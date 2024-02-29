namespace MainApp;

public class Transport
{
    public int HeshCode { get; set; }
    public string Model { get; set; }
    public double Fuel { get; set; }
    public int Seats { get; set; }
    public int Power { get; set; }
    public int Speed { get; set; }
    public int Price { get; set; }


    public Transport(){}

    public Transport(int heshcode,string model,double fuel,int seats,int power,int speed,int price)
    {
        HeshCode = heshcode;
        Model = model;
        Fuel = fuel;
        Seats = seats;
        Power = power;
        Speed = speed;
        Price = price;
        System.Console.WriteLine("Object Has been created: ");
    }

    public string GetInfo()
    {
        return $"HeshCode: {HeshCode}\nModel: {Model}\nSeats: {Seats}\nPower: {Power}hp\nSpeed: {Speed} kmh\nFuel: {Fuel}\nPrice: {Price}$";
    }
}
