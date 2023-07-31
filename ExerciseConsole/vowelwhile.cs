using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class vowelwhile
    {
        string a = "Have a Nice Day";
        int b  =0 ;
        int count;
        int count1;
        public void v1()
        {
           
            a = a.ToLower();
            char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };

            while(b<a.Length)
            {
               
                if (vowel.Contains(a[b]))
                {
                   
                    count++;
                }
                else
                {
                    count1++;
                }
                b++;
            }
            Console.WriteLine("vowles" + count);
            Console.WriteLine("not a vowles" + count1);
        }
    }
}
