using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class factorial
    {
        public void F1()
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            for (int b= 1;b<a;b++)
            {
                count = count * a;
            }
            Console.WriteLine("It is fatorial num" + count);
        }
    }
}
