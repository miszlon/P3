using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium1_Poprawa
{
    class Zadanie2
    {
        //Zadanie 2 - 
        public static void Zadanie2F(double kwota, int iloscMiesiecy)
        {

            for (int i = 0; i < iloscMiesiecy; i++)
            {
                kwota = kwota + (kwota * 10 / 100);
            }
            Console.WriteLine(kwota);
        }
    }
}
