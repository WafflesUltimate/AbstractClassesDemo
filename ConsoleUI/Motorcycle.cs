using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        internal override void DriveAbstract() 
        {
            Console.WriteLine("The Motorcycle has started");
        }

        internal string hasSideCart {get; set;}

        internal override void DriveVirtual() 
        {
            Console.WriteLine("The Motorcycle is speeding");
        }

    }
}
