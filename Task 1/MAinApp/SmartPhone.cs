namespace MAinApp;


public class SmartPhone: Computer
{
    public int NumberOfSelfies { get; set; }

    public void TakeSelfie()
    {
        NumberOfSelfies++;
    }

    public void PhoneInfo()
    {
        System.Console.WriteLine($"{base.GetAllInfo()}\nSelfies : {NumberOfSelfies}");
    }
}

