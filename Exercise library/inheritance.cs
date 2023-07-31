using System;

namespace ajayLibrary
{
    public class Sum
    {
        int a = 56;
        int b;
        int temp;
        public void H1()
        {
            Console.WriteLine("enter the value");
            temp=Convert.ToInt32(Console.ReadLine());
            b = a + temp;
            Console.WriteLine(b);       
        }
        
    }
    public class S:Sum
    {
        int a = 100;
        int b;
        int temp;
        public void H2()
        {
            Console.WriteLine("enter the value");
            temp = Convert.ToInt32(Console.ReadLine());
            b = a + temp;
            Console.WriteLine(b);
        }

    }
    public class N:S
    {

    }

}
