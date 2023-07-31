using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class vowelarray
    {
        public string a;
       
        int  temp ;
        int temp1;
       
        public void m1()
        {
            a = Console.ReadLine();
           
            a = a.ToLower();

            
         

            for (int b=0 ; b < a.Length; b++) 
            {

                
                if (a[b] == 'a' || a[b] == 'e' || a[b] == 'i' || a[b] == 'o' || a[b] == 'u')
                {
                    Console.WriteLine(a[b]);
                    temp++;
                }
                else
                {
                    Console.WriteLine(a[b]);
                    temp1++;
                }

            }
            Console.WriteLine(temp);
            Console.WriteLine(temp1);

        }

      

        

    }
}
