using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
   public class mark
    {
      public int tam, eng, maths;
      
    }

   public class studs
    {
        int total;
        int avg;
        mark g;
        public studs(mark a)
        {
            Console.WriteLine(a.tam + " tam mark");
            Console.WriteLine(a.eng + " eng amrk");
            Console.WriteLine(a.maths + " maths mark");
            g = a;
           
        }
        
        public void Total()
        {
            total = g.tam +g. eng + g.maths;
            Console.WriteLine(total);
        }
        public void Avg()
        {
            avg = total / 3;
            Console.WriteLine(avg);
        }
    }


}
