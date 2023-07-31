 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class business
    {
        public void Data()
        {
            Console.WriteLine("enter your first name");
            string a = Console.ReadLine();
            Console.WriteLine("enter your last nmae");
            string b = Console.ReadLine();
            Console.WriteLine("enter the email id");
            string c = Console.ReadLine();

            Console.WriteLine("your first name is" + a + "last name" + b + "your email id is" + c);

        }
    }
}
