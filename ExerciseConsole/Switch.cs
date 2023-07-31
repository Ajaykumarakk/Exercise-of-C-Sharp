using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class Days
    {
        int day;            
        public void D1()
        {
            Console.WriteLine("Enter the number");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not matched");
                    break;

            }
     
            

            
        }
        public void B1()
        {
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                if(i==50)
                {
                   continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
