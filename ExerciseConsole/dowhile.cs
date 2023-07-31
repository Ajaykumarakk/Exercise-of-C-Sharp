using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class dowhile
    {
        public void D1()
        {
            int b;

            do
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");

                b = Convert.ToInt32(Console.ReadLine());

                switch (b)
                {
                    case 1:

                        int first = Convert.ToInt32(Console.ReadLine());
                        int second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first + second);
                        break;
                    case 2:
                        int First = Convert.ToInt32(Console.ReadLine());
                        int Second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(First - Second);
                        break;
                    case 3:
                        int firsts = Convert.ToInt32(Console.ReadLine());
                        int seconds = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(firsts * seconds);
                        break;
                }
            }
            while (b != 0);
            }
    } 
}
