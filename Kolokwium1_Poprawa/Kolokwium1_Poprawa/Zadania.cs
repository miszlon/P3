using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium1_Poprawa
{
    class Zadania
    {
        //Zadanie 1 - 
        public static void ObliczanieVat(double sumaCen23, double sumaCen7, double sumaCen3)
        {
            double podatek23 = sumaCen23 * 23 / 100;
            double podatek7 = sumaCen7 * 7 / 100;
            double podatek3 = sumaCen3 * 3 / 100;

            Console.WriteLine("Podatek 23 % = " + podatek23);
            Console.WriteLine("Podatek 7% = " + podatek7);
            Console.WriteLine("Podatek 3% = " + podatek3);
        }
        
        //Zadanie 3 
        
    }
}

