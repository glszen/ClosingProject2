﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosingProject2
{
    public class MobilePhone : BaseMachine
    {

        public MobilePhone(DateTime productionDate, string serialNumber, string name, string description, string operationSystem) : base(productionDate, serialNumber, name, description, operationSystem) { }
         
        public bool TrLicence { get; set; } = true;

        public override void PrintInfo()
        {
            Console.WriteLine("Production Name: " + ProductionDate);
            Console.WriteLine("Serial Number: " + SerialNumber);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("OperationSystem: " + OperationSystem);
            Console.WriteLine("TR Licence: " + TrLicence);
        }

        public override void GetProductName()
        {
            Console.WriteLine("Your Phone Name is  --->  Mobile Phone Name is " + Name);
        }

    }
}
