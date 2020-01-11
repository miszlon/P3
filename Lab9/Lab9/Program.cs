using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int liczba = Convert.ToInt32(Console.ReadLine());
            //int wynik, resztaZDzielenia;
            //(wynik, resztaZDzielenia) = liczba.DzielenieZReszta(3);
            //Console.WriteLine($"{liczba}/3={wynik}r{resztaZDzielenia}");


            //napisz extension method dla typu string który zliczy ile jest danych liter w tekscie

            //string tekst = "Cip Cip Cip";
            //Console.WriteLine(tekst.CountingChars('c'));

            Reklama reklama = new Reklama(
                "Kup Teraz!", PrzedzialWiekowy.Dorosli | PrzedzialWiekowy.Mlodziez, Zaintersowania.Elektronika);


        }
    }
}
