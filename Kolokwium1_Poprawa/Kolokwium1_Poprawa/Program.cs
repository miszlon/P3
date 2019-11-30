using System;

namespace Kolokwium1_Poprawa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            Console.WriteLine("--------------");
            Console.WriteLine("ZADANIE 1");
            Console.WriteLine("--------------");
            Console.Write("Podaj kwotę o podatku 23% = ");
            double podatek23 = double.Parse(Console.ReadLine());
            Console.Write("Podaj kwotę o podatku 7% = ");
            double podatek7 = double.Parse(Console.ReadLine());
            Console.Write("Podaj kwotę o podatku 3% = ");
            double podatek3 = double.Parse(Console.ReadLine());
            Zadania.ObliczanieVat(podatek23, podatek7, podatek3);

            //Zadanie 2
            Console.WriteLine("--------------");
            Console.WriteLine("ZADANIE 2");
            Console.WriteLine("--------------");
            Console.Write("Kwota zadłużenia ");
            double kwotaPozyczki = double.Parse(Console.ReadLine());
            Console.Write("Ile miesięcy opóźnienia = ");
            int iloscMiesiecy = int.Parse(Console.ReadLine());
            Zadanie2.Zadanie2F(kwotaPozyczki, iloscMiesiecy);

            //Zadanie3
            Console.WriteLine("--------------");
            Console.WriteLine("ZADANIE 3");
            Console.WriteLine("--------------");
            Zadanie3.Slownik();
        }
    }
}
