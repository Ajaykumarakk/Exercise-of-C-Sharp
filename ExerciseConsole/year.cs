using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class year
    {
        int a = 2024;

        public void mm()
        {
            if(2027%4==0)
            {
                Console.WriteLine("leapyear");
            }
            else 
            {
                Console.WriteLine("not a leapyear");
            }
        }
    }
}
