                using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class vechicle
    {
        public string name;
        public string num;

        public string idcard { get; internal set; }
    }

    class vechicleinfo
    {

        private string a;
        private vechiclereport VP;

        public vechicleinfo()
        {
            var v = GetVechicleinfo();
           VP = new vechiclereport(v);

        }
        public vechicleinfo(string name) 
        {
            Console.WriteLine(name);
            VP = new vechiclereport(GetVechicleinfo());
        }
        public void Getinsuranceno()
        {
            var P = VP.Getinsuranceno();
            Console.WriteLine(P.name + P.num);

        }
        private vechicle GetVechicleinfo()
        {
            vechicle a= new vechicle();
            a.name = "ajay";
            a.num = "TN 33 X 7493";

            return a;

        }

    }
    class vechiclereport
    {
        public vechicle v;
       

        public vechiclereport(vechicle v)
        {
            this.v = v;

        }
        public vechicle Getinsuranceno()
        {
            return v;
        }
    }
}
