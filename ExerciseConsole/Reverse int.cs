using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class Reverse

    {

        
        public void R1()
        {
            
            

            Console.WriteLine("Enter the value");
            int no = Convert.ToInt32(Console.ReadLine());


            int temp = 0;

            while (no > 0)
            {
                temp = (temp * 10) + no % 10;
                no = no / 10;
            }
            Console.WriteLine(temp);
        }
    }
}
