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

        public override void GetProductName()
        {
            Console.WriteLine("Your Computer Name is  --->  Computer Name is " + Name);
        }




    }
}
