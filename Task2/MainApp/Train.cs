namespace MainApp;

public class Train :Transport
{
    public string Classes { get; set; }

    public Train(int heshcode,string model,double fuel,int seats,int power,int speed,string classes,int price) :base(heshcode,model,fuel,seats,power,speed,price)
    {
        Classes = classes;
    }

    public void AddClasses()
    {
        Classes = Console.ReadLine();
        if (Classes == "1 class")
        {
            Price += 100;
        }else if(Classes == "Bussnes")
        {
            Price += 80;
        }else if(Classes == "PresidentCabin")
        {
            Price += 1000;
        }
    }

    public void GetTrainInfo()
    {
        System.Console.WriteLine(base.GetInfo());
        System.Console.WriteLine($"Class: {Classes}");
    }
}
