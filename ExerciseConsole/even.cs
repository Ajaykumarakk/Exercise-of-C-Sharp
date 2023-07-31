using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
   partial class oddeven
    {
        int aa = 4;
        public void even()
        {
            if(aa%4==0)
            {
                Console.WriteLine("even no");
            }
            else
            {
                Console.WriteLine("odd no");
            }
        }
    }
}
