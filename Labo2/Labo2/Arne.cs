﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Arne
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        public int AddNumbers()
        {
            int som = Getal1 + Getal2;

            return som;
        }

        public void Writeline()
        {
            Console.WriteLine("Dit is mijn methode!");
        }
    }
}
