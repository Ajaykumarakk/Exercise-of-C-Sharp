using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class typecasting
    {
        int total;
        public void Readmark()
        {
            Console.WriteLine("Enter the tamil mark");
            string tamil = Console.ReadLine();
            Console.WriteLine("Enter the English mark");
            string English = Console.ReadLine();
            Console.WriteLine("Enter the maths mark");
            string mathes = Console.ReadLine();
            Console.WriteLine("Enter the science mark");
            string science = Console.ReadLine();
            Console.WriteLine("Enter the SS mark");
            string SS = Console.ReadLine();

            int Tamil = Convert.ToInt16(tamil);
            int English2 = Convert.ToInt16(English);
            int maths3 = Convert.ToInt16(mathes);
            int science4 = Convert.ToInt16(science);
            int ss5 = Convert.ToInt16(SS);
             total = Tamil + English2 + maths3 + science4 + ss5;
            Console.WriteLine("your total mark is " + total);
    }

        public void Calavg()
        {
            Console.WriteLine("your avg is" + total / 5);

        }

       
    }
}
