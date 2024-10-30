using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosingProject2
{
    public class Computer : BaseMachine
    {
        public Computer(DateTime productionDate, string serialNumber, string name, string description, string operationSystem) : base(productionDate, serialNumber, name, description, operationSystem) { }

        public bool Bluetooth { get; set; } = true;
        public int _usbportnumber;
        public int UsbPortNumber

        {
            get { return _usbportnumber; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbportnumber = value;
                    Console.WriteLine("USB Port Number is: " + _usbportnumber);
                }
                else
                {
                    _usbportnumber = -1;
                    Console.WriteLine("Incorrect Enter.");
                }
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Production Name: " + ProductionDate);
            Console.WriteLine("Serial Number: " + SerialNumber);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " +Description);
            Console.WriteLine("OperationSystem: " + OperationSystem);
            Console.WriteLine("Bluetooth: " + Bluetooth);
            Console.WriteLine("Usb Port Number: " + _usbportnumber);
        }

        public override void GetProductName()
        {
            Console.WriteLine("Your Computer Name is  --->  Computer Name is " + Name);
        }





    }
}
