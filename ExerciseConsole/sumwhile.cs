using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class sumwhile
    {
        
        int[] n = new int[] { 10, 20, 30 };
        int total;
        public void s1()
        {
            int d = 0;

            while (d<n.Length)
            {
                total= total+ n[d];
                d++;
            }
            Console.WriteLine(total);
        }
    }
}
