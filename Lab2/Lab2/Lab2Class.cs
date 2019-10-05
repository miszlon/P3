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
            string odpowiedz = "";
            while (!odpowiedz.Equals(escape))
            {
                odpowiedz = Console.ReadLine();
                switch(odpowiedz)
                {
                    case "1":
                        UnikalnaNazwa("1");
                        break;
                    case "2":
                        UnikalnaNazwa("2");
                        break;
                    case "3":
                        UnikalnaNazwa("3");
                        break;

                }

            }
        }

        static void UnikalnaNazwa(string nazwaProduktu)
        {
            iloscProduktow++;
            Console.WriteLine("Produkt ["+nazwaProduktu+"]");
        }


    }
}
