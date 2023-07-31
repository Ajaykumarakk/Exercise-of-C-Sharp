using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class Armstrom

    {
       public Armstrom()
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int b = n;
            int temp = 0;
            while (n !=0)
            {
                int c = n % 10;

                temp = temp + (b * b * b);
                n = n / 10;
            }
                if(b==temp)
                {
                    Console.WriteLine("Armstrom");
                }
                else
                {
                    Console.WriteLine("not a Armstrom");
                }
            
           
        }
    }
}
