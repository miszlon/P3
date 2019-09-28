using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Lab2Class
    {
        static int iloscProduktow = 0;
        public static void Prdoukty()
        {
            string escape = "exit";

            while(Console.ReadLine() != escape)
            {
                Console.WriteLine(UnikalnaNazwa(iloscProduktow++));
            }
        }

        static string UnikalnaNazwa(int numer)
        {
            return "Produkt " + numer;
        }


    }
}
