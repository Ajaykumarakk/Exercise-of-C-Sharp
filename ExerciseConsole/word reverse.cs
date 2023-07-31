using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class word_reverse
    {
        public void W1()
        {
           
            Console.WriteLine("Enter the Word");
            string a = Console.ReadLine();
        
            string[] reverse = a.Split(" ");

            for (int i = reverse.Length-1; i >= 0; i--)
            {
                Console.Write(reverse[i]+" ");           
            }
        }
    }
}