using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class foreven
    {
        public void even()
        {
            Console.WriteLine("even");
            for (int a = 0; a <=100; a++)
            { 

                if(a%2==0)
                {
                    Console.WriteLine(a);
                }
            }
        }

        public void odd()
        {
            Console.WriteLine("odd");

            for (int b = 0; b <= 100; b++) 

            if(b%2!=0)
            {
                    Console.WriteLine(b);
            }
        }

    }
  
    
}
