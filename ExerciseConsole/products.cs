using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class products
    {
        int total;
       public int sum()
        {
            Console.WriteLine("Enter the applekg");
            int apple = 200;
            int Applekg = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter the orangekg");
            int orange = 100;
            int Orangekg = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter the totatokg");
            int tomato = 50;
            int Tomatokg = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter the potatokg");
            int potato = 40;
            int Potatokg = Convert.ToInt32(Console.ReadLine());
            

            total = apple* Applekg + orange* Orangekg + tomato* Tomatokg + potato* Potatokg;
            return total;

        }
    }
    class Total
    {
        public void data()
        {
            products obj = new products();
            int  value = obj.sum();

            Console.WriteLine(value);
        }
    }

}
