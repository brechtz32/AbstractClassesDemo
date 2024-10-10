using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is driving too fast");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"You can drive while doing a wheely!");
        }
    }
}
