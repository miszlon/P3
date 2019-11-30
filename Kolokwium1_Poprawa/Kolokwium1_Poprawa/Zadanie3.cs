using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium1_Poprawa
{
    class Zadanie3
    {
        //Wyszukiwanie wyrazu w tablicy
        public static void Slownik()
        {
            string[,] slownik = new string[2, 5];
            wpisywanieWyrazow();
            string Slowo;
            Console.Write("Proszę podać które słowo chcesz przetłumaczyć: ");
            Slowo = Console.ReadLine();
            for (int i = 0; i < slownik.GetLength(0); i++)
            {
                for (int j = 0; j < slownik.GetLength(1); j++)
                {
                    if (Slowo == slownik[i, j])
                    {
                        Console.WriteLine(slownik[i + 1, j]);
                    }
                    else
                    {
                        Console.WriteLine("Brak takiego słowa w słowniku");

                    }
                }
            }
        }

        public static void wpisywanieWyrazow()
        {
            
            string[,] slownik = new string[2, 5];

            for (int i = 0; i < slownik.GetLength(0); i++)
            {
                for (int j = 0; j < slownik.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        Console.Write("Podaj polskie słowo: ");
                        slownik[i, j] = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Podaj angielskie słowo: ");
                        slownik[i, j] = Console.ReadLine();
                    }
                }
            }
        }
    }
}
