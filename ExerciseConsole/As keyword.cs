using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class Studend
    {
        public void s1()
        {
            object[] MyObjects = new object[4];
            MyObjects[0] = 1;
            MyObjects[1] = "hello";
            MyObjects[2] = "Student";
            MyObjects[3] = "Teacher"; 
            for (int i = 0; i < 4; i++)
            { 
                string s = MyObjects[i] as string;
                Console.WriteLine(MyObjects[i]);
                if (s != null)
                {
                    Console.WriteLine("is a string");
                }
                else
                {
                    Console.WriteLine("is not a string");
                }
               
            }
           
        }

    }
}
