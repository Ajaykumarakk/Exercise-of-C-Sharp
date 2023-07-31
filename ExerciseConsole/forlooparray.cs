using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class forarray
    {
        public void NA()
        {
            int[] a = new int[] { 10, 20, 30, 50, 60, 80 };
            int temp=0;
            
                for (int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
                temp = temp + a[i];
            }

            Console.WriteLine(temp);

        }

        public void AN()
        {
            Console.WriteLine("enter the value");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[size];
            int temp = 0;


            for(int c=0;c<b.Length;c++)
            {
                b[c] = Convert.ToInt32(Console.ReadLine());
                temp = temp + b[c];
            }
            Console.WriteLine(temp);
        }

    }
}
