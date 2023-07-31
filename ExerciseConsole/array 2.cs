using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{ 
    class student1
    {

        int total;
        int avg;
        
        private student Getinfo()
        {
            student a = new student();
            Console.WriteLine("enter name");
            a.name = Console.ReadLine();
            Console.WriteLine("enter tam mark");
            a.tam =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter eng mark");
            a.eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ss mark");
            a.ss = Convert.ToInt32(Console.ReadLine());
            

            return a;
        }

        public student[] getinfomation()
        { 

            student[] studs = new student[2];
            studs[0] = Getinfo();
            studs[1] = Getinfo();
            return studs;
        }
      
          
            public char grade(student a)
            {


            total = a.tam + a.eng + a.ss;
            avg = total / 3;

            char grade = 'F';


                if (avg > 91)
                {
                    grade = 'A';

                }
                else if (avg > 81)
                {
                    grade = 'B';

                }
                else if (avg > 71)
                {
                    grade = 'c';
                }
                else if (avg > 51)
                {
                    grade = 'D';
                }
                return grade;

            } 
    }
}
