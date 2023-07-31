using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class duplicate
    {


        string a;

        string temp = string.Empty;
        string dupl = string.Empty;
        int count = 0;
      


        public void dup()
        {

            Console.WriteLine("enter the word");
            a = Console.ReadLine();

            a = a.ToLower();

            for (int i = 0; i < a.Length; i++)
            {



                if (temp.Contains(a[i]))
                {



                    if (!(dupl.Contains(a[i])))
                    {

                        dupl = dupl + a[i];
                        count++;
                    }

                }
                else
                {
                    temp = temp + a[i];

                }


            }
            Console.WriteLine(temp);
            Console.WriteLine(dupl);
            Console.WriteLine("count"+ count);
        }
    }


}       

        

    

