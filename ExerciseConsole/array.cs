using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class student
    {
        public string name;
        public int tam;
        public int eng;
        public int maths;
        public int science;
        public int ss;
        
    }
        class info
    {
        int total;
        int total1;
        int avg;
        int avg1;
        public void array()
        {
            student[] s = new student[2];
            s[0] = new student();
            Console.WriteLine(s[0].name = "harish");

            Console.WriteLine("Tamil mark");
            s[0].tam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("English mark");
            s[0].eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maths mark");
            s[0].maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Science mark");
            s[0].science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SS mark");
            s[0].ss = Convert.ToInt32(Console.ReadLine());

            s[1] = new student();
            Console.WriteLine(s[1].name = "navee");
            Console.WriteLine("Tamil mark");
            s[1].tam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("English mark");
            s[1].eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maths mark");
            s[1].maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Science mark");
            s[1].science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SS mark");
            s[1].ss = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(s[0].name);
            total = s[0].tam + s[0].eng + s[0].maths + s[0].science + s[0].ss;
            Console.WriteLine(total);

            Console.WriteLine(s[1].name);
            total1 = s[1].tam + s[1].eng + s[1].maths + s[1].science + s[1].ss;
            Console.WriteLine(total1);
        
               
            avg = total / 5;
            Console.WriteLine(avg);

            avg1 = total1 / 5;
            Console.WriteLine(avg1);



            if (avg > 91)
            {
                Console.WriteLine('A');
            }
            else if (avg > 81)
            {
                Console.WriteLine('B');

            }
            else if(avg >50)
            {
                Console.WriteLine('C');

            }
            else if(avg < 49 )
            {
                Console.WriteLine('D');
            }

            if (avg1 > 91)
            {
                Console.WriteLine('A');
            }
            else if (avg1 > 81)
            {
                Console.WriteLine('B');

            }
            else if (avg1 > 71)
            {
                Console.WriteLine('C');

            }
            else if (avg1 > 49)
            {
                Console.WriteLine('D');
            }
        }
    }
}

