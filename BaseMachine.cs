using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosingProject2
{
    public abstract class BaseMachine
    {
        public DateTime ProductionDate { get; set; }


        public string SerialNumber { get; set; }


        public string Name { get; set; }


        public string Description { get; set; }


        public string OperationSystem { get; set; }

        public BaseMachine(DateTime productionDate, string serialNumber, string name, string description, string operationSystem)
        {
            ProductionDate = productionDate;
            SerialNumber = serialNumber;
            Name = name;
            Description = description;
            OperationSystem = operationSystem;
        }


        public virtual void PrintInfo()
        {
            Console.WriteLine(ProductionDate);
            Console.WriteLine(SerialNumber);
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine(OperationSystem);

        }

        public abstract void GetProductName();
    }
}
