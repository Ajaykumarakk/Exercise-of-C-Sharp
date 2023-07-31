using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class word
    {
       public void F1()
        {
            
            Console.WriteLine("enter the word");
            string a = Console.ReadLine();

            char[] vow = new char[] { 'a', 'e', 'i', 'o', 'u' };

           

            for (int w = 0; w <vow.Length; w++) 
            {
                int temp = 0;
                
                
                for (int j=0;j<a.Length;j++)
                {

                    if (vow[w] == a[j])
                    {


                        temp++;
                    }

                    
                }
                Console.WriteLine($"{vow[w]} is {temp}");
            }
        }
    }
}
