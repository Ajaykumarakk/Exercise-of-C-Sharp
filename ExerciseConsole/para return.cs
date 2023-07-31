using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class students
    {
        public string firstname;
        public string Lastname;
        public string Email;
        public short age;
        public long phoneno;

    }



    class data
    {
        public void para(students a)
        {
            Console.WriteLine(a.firstname + "enter the fisrtname");
            Console.WriteLine(a.Lastname + "enter the Lastname");
            Console.WriteLine(a.Email + "enter the Emial");
            Console.WriteLine(a.age + "enter the age");
            Console.WriteLine(a.phoneno + "enter the phoneno");
        }

        public students info()
        {
            students obj1 = new students();
            Console.WriteLine("enter the first name");
            obj1.firstname = Console.ReadLine();
            Console.WriteLine("enter the last name");
            obj1.Lastname = Console.ReadLine();
            Console.WriteLine("enter the  email");
            obj1.Email = Console.ReadLine();
            Console.WriteLine("enter the age");
            obj1.age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the mobile number");
            obj1.phoneno = Convert.ToInt64(Console.ReadLine());
            return obj1;
        }


    }
}


   
