using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class Each
    {
        public void E1()
        { 
            List<string> lst = new List<string>();
            lst.Add("Ajay");
            lst.Add("Kumar");
              
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Book"); 
            dic.Add(2, "Note");
            
            foreach (string b in lst)
            {
                Console.WriteLine(b);
            }          
               
        }     
    }
}
