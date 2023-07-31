using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class opertors
    {
        
           int a = 10;
        int b = 20;

        public void Arithamatic()
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
        public void Assigment()
        {
            Console.WriteLine(a += b);
            Console.WriteLine(a -= b);
        }

        public void compersion()
        {
            Console.WriteLine(a >= b);
            Console.WriteLine(a < b);
        }

        public void logical()
        {
            Console.WriteLine(a >= b && a < b);
            Console.WriteLine(a >= b || a < b);
        }

        public void incdec()
        {
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            Console.WriteLine(b--);
            Console.WriteLine(--b);
        }

        

               

    }
}
