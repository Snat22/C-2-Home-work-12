namespace MainApp;

public class PasangerPlane :AirPlane
{
    public string Classes { get; set; }
    public PasangerPlane(int heshcode,string model,double fuel,int seats,int power,int speed,string company,int price,string classes) :base(heshcode,model,fuel,seats,power,speed,company,price)
    {
       Classes = classes; 
       System.Console.WriteLine("Passanger Plane created: ");
    }

    public void AddClassPlane()
    {
    string change = Console.ReadLine();
    
        if (change == "Busnes")
        {
            Price += 100;
        }else if(change == "first class"||Classes ==" 1 Class")
        {
            Price += 150;
        }else if(change == "Private")
        {
            Price += 1000;
        }

    }
    public void GetPasangerPlaneInfo()
    {
        System.Console.WriteLine($"{base.GetInfo()}\nClass: {Classes}");
    }
}
