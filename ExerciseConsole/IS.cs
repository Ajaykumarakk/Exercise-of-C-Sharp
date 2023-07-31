using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class IS
    {
        
        public void I1()
        {


            // Console.WriteLine("enter the word");
            var a = "akaj";

                

            if (a is string)
            {
                Console.WriteLine("correct");


            }
            else
            {
                Console.WriteLine("not correct");
            }
        } 
    }
}
