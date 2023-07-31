using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class vowelsarray2
    {
        public string a;

        public void m3()
        {
            a = Console.ReadLine();

            a = a.ToLower();




            for (int b = 0; b < a.Length; b++)
            {


                if (!(a[b] == 'a' || a[b] == 'e' || a[b] == 'i' || a[b] == 'o' || a[b] == 'u'))
                {
                    Console.WriteLine(a[b]);

                }
            }

        }
    }
}
