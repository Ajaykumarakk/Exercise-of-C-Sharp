using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class Pass
    {

       public void P1(ref int num)
        {
            num++;
        }
        public void P2()
        {
            int value = 10;

            P1(ref value);
            Console.WriteLine(value);
        }

        
    }
}
