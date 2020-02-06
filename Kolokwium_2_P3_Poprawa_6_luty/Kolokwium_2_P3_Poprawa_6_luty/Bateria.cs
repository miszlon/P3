using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2_P3_Poprawa_6_luty
{
    class Bateria : Interface1
    {
        int Pojemnosc = 100;
        public void Zasilaj(int energia)
        {
           if(Pojemnosc > 0)
            {
                Console.WriteLine("OK");
            }
        }
    }
}
