using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class value_check
    {
        int[] a = new int[] { 4, 5, 6, 7 };
        int[] b = new int[] { 4, 5, 6,8 };

        int temp;
        public void V1()
        {
            if(a.Length==b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (a[i] == b[i])
                    {
                        temp++;
                    }
                 }
                    if (temp == b.Length)
                    {
                        Console.WriteLine("same");
                    }
                    else
                    {
                        Console.Write("not a same");
                    }
                
                
            }
            else
            {
                Console.WriteLine("Not a same");
            }
        }
    }
}
