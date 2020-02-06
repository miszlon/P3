using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2_P3_Poprawa_6_luty
{
    class Składnik
    {
        public Składnik(int weglowodany, int tluszcz, int sol)
        {
            Weglowodany = weglowodany;
            Tluszcz = tluszcz;
            Sol = sol;
        }

        public int Weglowodany { get; set; }
        public int Tluszcz { get; set; }
        public int Sol { get; set; }

    }
}
