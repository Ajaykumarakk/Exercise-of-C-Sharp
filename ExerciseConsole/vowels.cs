using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class vowels
    {
        public void vow()
        {
            Console.WriteLine("enter a letter to check vowel or not\n");
            char letter = Convert.ToChar(Console.ReadLine());

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("this is vowels");
            }
            else
            {
                Console.WriteLine("this is not vowels");
            }
        }
    }
}
