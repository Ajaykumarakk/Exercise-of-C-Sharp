﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajayconsole.cs
{
    class pattern
    {
        int a;
        public void P1()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j =1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
