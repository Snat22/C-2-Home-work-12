namespace MainApp;

public class AirPlane :Transport
{
    public string Company { get; set; }

    public AirPlane(int heshcode,string model,double fuel,int seats,int power,int speed,string company,int price) :base(heshcode,model,fuel,seats,power,speed,price)
    {
        Company = company;   
    }

public void GetAirPlaneInfo(){
    
System.Console.WriteLine($"{base.GetInfo()}\nCompany:{Company}");
}

}
