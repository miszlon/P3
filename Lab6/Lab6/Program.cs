using System;
using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace Lab_6 //zjazd 6
{
    class Osoba
    {
        public int Id;
        public string imie;
        public string nazwisko;

        public Osoba(int Id, string imie, string nazwisko)
        {
            this.Id = Id;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lista = Enumerable.Range(100, 150).ToList();
            List<int> podzielnaPrzez3 =
                lista.Where(x => x % 3 == 0).ToList();
            int elementynaStronie = 25;
            int nrStrony = 2;
            List<int> strona = lista.Skip(elementynaStronie * (nrStrony - 1)).Take(elementynaStronie).ToList();

            double srednia = lista.Average();
            Console.WriteLine(srednia);

            foreach( var item in strona) //listy
            {
                Console.WriteLine(item);
            }
            List<Osoba> osoby = Enumerable.Range(1, 50)
                .Select(x => new Osoba()
                {
                    Id = x,
                    imie = x.ToString(),
                    nazwisko = "aaa"

                }).ToList();
            osoby[30].nazwisko = "bbb";

            ~~foreach (var item in osoby)
                Console.WriteLine($"{item.Id}: {item.imie}:{item.nazwisko}");

            IEnumerable<int> ids = osoby.Select(x => x.Id);

            //foreach (var item in ids)
            //Console.WriteLine(item);

            osoby.Select(x => x.nazwisko).Distinct()
                .ToList().ForEach(Console.WriteLine);
            foreach (var item in nazwiska)
                Console.WriteLine(item);

            int pierwszy = lista.FirstOrDefault(x => x%300 == 0 );
            Console.WriteLine(pierwszy);
            var intGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            var nameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var lastGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());

            Osoba random = new Osoba(
                intGenerator.Generate().Value,
                nameGenerator.Generate(),
                lastGenerator.Generate());
            Console.WriteLine($"{random.Id}:{random.imie}:{random.nazwisko}");
            //lab 6
            List<Osoba> osoby = Enumerable.Range(1, 100)
                .Select(x => new Osoba(intGenerator.Generate().Value, nameGenerator.Generate(), lastGenerator.Generate())).ToList();

            foreach (var item in osoby)
                Console.WriteLine(item.Id + " " + item.imie + " " + item.nazwisko);



        }
    }
}
//Srednia elementów
