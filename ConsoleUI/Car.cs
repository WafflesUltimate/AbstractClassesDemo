using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        internal override void DriveAbstract() 
        {
            Console.WriteLine("The car has started.");
        }
        internal string hasTrunk {  get; set; }
        internal virtual void DriveVirtual() 
        {
            Console.WriteLine("The car is speeding.");
        }
    }
}
