using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class wordcount
    {
        string N = "Have a nice day";
        int temp;
       
        public void W1()
        {
            N = N.Trim();
            for (int i = 0;i<N.Length;i++)
            {
                if(N[i]==' ')
                {
                    temp++;
                }
                
            }
            Console.WriteLine("wordcount");
            Console.WriteLine(temp + 1);
        }

        public void W2()
        {
            Console.WriteLine("enter the word");
            string R = Console.ReadLine();

            var rr = R.Split(' ');

            Console.WriteLine(rr.Length);
        }
    }
}
