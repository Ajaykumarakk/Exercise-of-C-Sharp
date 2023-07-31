using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class product
    {
        public string name { get; set; }
        public double price { get; set; }
        public DateTime expirydate { get; set; }
        public double kg  { get; set; } 
    }
    class suger
    {
       
        public void A1()
        {
            product a = new product();

            Console.WriteLine("number");
            int n = Convert.ToInt32(Console.ReadLine());

            product[] aa = new product[n];

            for (int c = 0; c < n; c++) 
            {
                aa[c] = new product();

                Console.WriteLine("product name");
                aa[c].name = Console.ReadLine();
                Console.WriteLine("product price");
                aa[c].price =Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("product expirydate");
                aa[c].expirydate =Convert.ToDateTime( Console.ReadLine());
                Console.WriteLine("product kg");
                aa[c].kg =Convert.ToInt64 (Console.ReadLine());
            }

            for (int s = 0; s < n; s++)
            {
          
                Console.WriteLine("product name" + aa[s].name);
                Console.WriteLine("product price" + aa[s].price);
                Console.WriteLine("product expirydate" + aa[s].expirydate);
                Console.WriteLine("product kg" + aa[s].kg);
                Console.WriteLine("_________");
            }
        }

    }
    

    
}
