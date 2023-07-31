using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class Rade:IRace
    {
        public void R1 ()
        {
            Console.WriteLine("TVS");

        }
        public void R2()
        {
            Console.WriteLine("Hero");
        }
        public void R3()
        {
            Console.WriteLine("Honda");
        }
    }
    interface IRace
    {
        public static int a { get; set; }
        public void R1();
        public void R2();
        public void R3();

       
    }

    
    
}
