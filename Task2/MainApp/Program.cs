
using MainApp;
var car1 = new Car(1123,"Mercedes Benz",10.0,4,670,240,"Black",6800);
var airPlane = new AirPlane(1124,"AirBus",400,80,6000,500,"Fly Emirates",68000);
var train1 = new Train(1125,"PVD",500,120,1200,350,"First Class",500);
var passCar1 = new PasangerCar(1126,"AMG GT 63 S",10,5,680,240,"White Zhemchuk",180000,2);
var cargoCar1 = new CargoCar(1127,"Mercedes",25.0,2,800,200,"Grey",120000,4000);
var cargoPlane1 = new CargoPlane (1128,"Andreyevka",600.0,10,1000,500,"RF",2000000,10000);
var passPlane1 = new PasangerPlane(1129,"Boeng 747",500,80,4000,500,"Qatar Air",300,"Busnes");
System.Console.WriteLine("For Geting All info write <<AllInfo>> or <<GetAll>>");
string info = Console.ReadLine();
if (info == "AllInfo"||info == "GetAll")
{
System.Console.WriteLine("\n<=========CarInfo============>\n");
 car1.CarInfo();  
 System.Console.WriteLine("\n<=========AirPlans============>\n");
 airPlane.GetAirPlaneInfo();
  System.Console.WriteLine("\n<=========Trains============>\n");
  train1.GetTrainInfo();
System.Console.WriteLine("\n<=========PasanGerCar============>\n");
passCar1.GetPasangerCArInfo();
System.Console.WriteLine("\n<=========Cargo Car============>\n");
cargoCar1.CargoCarInfo();
System.Console.WriteLine("\n<=========Cargo Plane============>\n");
cargoPlane1.GetCargoPlaneInfo();
System.Console.WriteLine("\n<=========Pasanger Plane============>\n");
passPlane1.GetPasangerPlaneInfo();


}



try
{
    
// car1.CarInfo();
System.Console.WriteLine("if shumo mexohed ba Car power dobavit kuned <<P>>-po yo <<add>>-po dar console navised");
System.Console.WriteLine("if shumo mexohed ba Classi Plane ivaz kuned <<C>>-po yo <<class>>-po dar console navised");

string add = Console.ReadLine();
if (add == "add"||add=="P")
{  
System.Console.Write("Add power:");
car1.AddPower();
car1.CarInfo();

}else if(add == "C"||add == "class")
{
    System.Console.WriteLine("Chptaatonro bo kadom chipta ivaz mekuned:");
    System.Console.WriteLine("Classe:\n<<1 Class>>-- +150$\n<<first class>>-- +150$\n<<Private>>-- +1000$\n<<Busnes>>-- +100$");
    passPlane1.AddClassPlane();
    passPlane1.GetPasangerPlaneInfo();
}
}
catch (System.Exception)
{
    
    System.Console.WriteLine("Neverniy format:");
}

