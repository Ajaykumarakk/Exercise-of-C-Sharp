using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class data_collection
    {
        int age;
        string Name;
        string Education;
        public void Data()
        {
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Education");
            string Education = Console.ReadLine();

           

            Console.WriteLine($"Name:{Name} Age:{age} Education:{Education}");
        }

        public void Pmeter(String Name,int age,string Education)
        {
        

            Console.WriteLine($"Name:{Name} Age:{age} Education:{Education}");
        }

        

         
        
    }
}
