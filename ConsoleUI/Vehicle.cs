using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }

        public string Year { get; set; } = "2002";
        public string Make { get; set; } = "Car Make";
        public string Model { get; set; } = "Car Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"You are virtualy driving");
        }
    }
}
