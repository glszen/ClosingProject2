using ClosingProject2;

Program:

Console.WriteLine("Press 1 to produce a phone, press 2 to produce a computer.");
string Choise = Console.ReadLine();
if (Choise == "1")
{
    Console.Write("Production Date: ");
    DateTime productionDate = DateTime.Now;
    Console.WriteLine(productionDate);

    Console.Write("Serial Number: ");
    string serialNumber = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Description: ");
    string description = Console.ReadLine();

    Console.Write("Operation System: ");
    string operationSystem = Console.ReadLine();

    Console.Write("Is There TrLicence? (Y/N): ");
    string licenceInput = Console.ReadLine();
    bool licence = licenceInput.Equals("Y", StringComparison.OrdinalIgnoreCase);

    MobilePhone mobilePhone = new MobilePhone(productionDate, serialNumber, name, description, operationSystem);

    mobilePhone.GetProductName();

    mobilePhone.TrLicence = licence;

    mobilePhone.PrintInfo();
}

else if (Choise == "2")
{

    Console.Write("Production Date: ");
    DateTime productionDate = DateTime.Now;
    Console.WriteLine(productionDate);

    Console.Write("Serial Number: ");
    string serialNumber = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Description: ");
    string description = Console.ReadLine();

    Console.Write("Operation System: ");
    string operationSystem = Console.ReadLine();

    Console.Write("Is There Bluetooth? (Y/N): ");
    string bluetoothInput = Console.ReadLine();
    bool bluetooth = bluetoothInput.Equals("Y", StringComparison.OrdinalIgnoreCase);

    Console.Write("Usb Port Number (1/2): ");
    int UsbPortNumber = Convert.ToInt32(Console.ReadLine());

    Computer computer = new Computer(productionDate, serialNumber, name, description, operationSystem);

    computer.Bluetooth = bluetooth;

    computer._usbportnumber = UsbPortNumber;

    computer.GetProductName();
}

Console.WriteLine("All information has been successfully generated. Would you like to produce a new product?(Y/N) ");
string answer = Console.ReadLine();
answer = answer.ToLower();


if (answer == "y")
{
    goto Program;
}

else
{
    Console.WriteLine("Have a nice day!");
}

