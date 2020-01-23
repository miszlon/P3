using System;

namespace lab_ix
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int liczba = Convert.ToInt32(Console.ReadLine());

            int wynik, resztaZDzielenia;
            (wynik, resztaZDzielenia) = liczba.DzielenieZReszta(3);

            Console.WriteLine($"{liczba}/3 = {wynik}r{resztaZDzielenia}");
           

            
            string str = "Ala ma kota!";

            Console.WriteLine(str.LetterCounter('!'));
            

            Reklama reklama = new Reklama(
                "Kup teraz!",
                PrzedzialWiekowy.Dorosli | PrzedzialWiekowy.Mlodziez,
                Zainteresowania.Elektronika);

            Reklama reklama2 = new Reklama(
                "Kup teraz!",
                PrzedzialWiekowy.Dzieci,
                Zainteresowania.Gaming);

            // reklama.Test();
            // reklama2.Test();

            Console.WriteLine(
                reklama.PrzedzialWiekowy.hasForChild()
                );

            Console.WriteLine(
                reklama2.PrzedzialWiekowy.hasForChild()
                );
        }


    }
}
