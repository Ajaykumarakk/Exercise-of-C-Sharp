using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class reverse
    {
        string a;
        string Nav = string.Empty;
        public void R1()
        {
            Console.WriteLine("enter the word");
            a = Console.ReadLine();

            for(int s=a.Length-1;s>=0;s--)
            {
                Nav = Nav + a[s];
            }

            Console.WriteLine(Nav);
        }
    }
}
