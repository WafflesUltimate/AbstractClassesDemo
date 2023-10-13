using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        internal string Year = "2008";
        internal string Model = "Toyota";
        internal string Make = "Tundra";

        internal abstract void DriveAbstract(); 
        

        internal virtual void DriveVirtual() {}

        


    }
}
