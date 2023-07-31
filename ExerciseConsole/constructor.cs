using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class cons
    {
        
        int total;
        int avg;
        public cons()
        {
            Console.WriteLine("enter the Tamil mark");
            int tamil = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the English mark");
            int english = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the maths mark");
            int maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the science mark");
            int science = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the ss mark");
            int ss = Convert.ToInt16(Console.ReadLine());
            total = tamil + english + maths + science + ss;
            avg = total / 5;

        }
        public void Total()
        {
           
            Console.WriteLine($"Total:{total}");
           
        }
        public void Avg()
        {
            
            Console.WriteLine($"Avg:{ avg}");
           

        }
    }
}
