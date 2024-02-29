using MAinApp;

var com1 = new Computer();
com1.Ram = 16;
com1.KeyBoard = "qwerty";
com1.Storage = 256;
System.Console.Write("Added Ram: ");
com1.AddStorage();

var phone1 = new SmartPhone();
phone1.Ram = 4;
phone1.KeyBoard = "QWERTY";
phone1.Storage = 128;
phone1.NumberOfSelfies = 0;
phone1.TakeSelfie();


var noutbook = new Laptop();
noutbook.Ram = 32;
noutbook.KeyBoard = "MacKeyboard";
noutbook.Storage = 512;
noutbook.Weight = 16.5;
System.Console.WriteLine("\nLaptop Info: \n");
System.Console.WriteLine("___________--------------____________");

noutbook.Info();
System.Console.WriteLine("\nComputer Info: \n");
System.Console.WriteLine("___________--------------____________");

System.Console.WriteLine(com1.GetAllInfo());
System.Console.WriteLine("\nPhone Info");
System.Console.WriteLine("___________--------------____________");
phone1.PhoneInfo();