using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class swap

    {
        int a = 10;
        int b = 7;
        int c;

        public void s1()
        {
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    

        
       public void s2()

        {
            Console.WriteLine("enter the value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value");
             int b =Convert.ToInt32( Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    
}
