using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class Binominal_series
    {
        int a = 0;
        int b = 1;

        int temp;
        public void B1()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0;i<10;i++)
            {
                temp = a + b;
                a = b;
                b = temp;
                Console.WriteLine(temp);
            }
        }
    }
}
