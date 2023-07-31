using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class Ride
    {
        public void R1()
        {
            Console.WriteLine("Have a nice day");
            
        }
        
    }
    class Bike:Ride
    {

        public void R2()
        {
            base.R1();
            Console.WriteLine("good morning");
        }
    }
}
