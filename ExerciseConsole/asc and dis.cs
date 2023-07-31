using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class ascorder
    {
        int[] a = new int[] { 90, 5, 34, 100, 56, 1 };

        public void A1()
        {

            for (int i=0;i<a.Length;i++)
            {
                int temp = 0;


                for (int j =i+1;j<a.Length;j++)
                {
                    if(a[i]>=a[j])
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
               
            }
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);
            Console.WriteLine(a[5]);
          

        }
    }
}
