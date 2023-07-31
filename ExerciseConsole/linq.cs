using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class linq
    {
        public void L1()
        {
            List<string> name = new List<string>();
            name.Add("Ajay");
            name.Add("Harish");
            name.Add("Naveena");
            name.Add("Nithesh");

         foreach (string a in name)
            {
                Console.WriteLine(a);
            }

            var b = name.FirstOrDefault(x => x.Contains("P"));

            Console.WriteLine(b);

            var h = name.Where(c=> c.Contains("Harish"));
            Console.WriteLine(h);
         
        }
    }
}
