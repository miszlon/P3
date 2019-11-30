using System;
using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace Lab6
{
    class Osoba
    {
        public int id;
        public string imie;
        public string nazwisko;

    }

    class Program
    {
        static void Main(string[] args)
        {
            //List<int> lista = Enumerable.Range(100, 150).ToList();
            //List<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0).ToList();

            //int elementyNaStronie = 25;
            //int nrStrony = 2;
            //List<int> strona = lista.Skip(elementyNaStronie * (nrStrony - 1)).Take(elementyNaStronie).ToList();

            //double srednia = lista.Average();
            //Console.WriteLine(srednia);

            ////foreach (var item in strona)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //List<Osoba> osoby = Enumerable.Range(1, 50).Select(x => new Osoba() { id = x, imie = x.ToString(), nazwisko = "Milosz" }).ToList();

            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}: {item.imie}, {item.nazwisko}");
            //}



            var intGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            var nameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var lastGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            //Osoba random = new Osoba(
            //    intGenerator.Generate().Value, nameGenerator.Generate(), lastGenerator.Generate());
            //Console.WriteLine($"{random.id}: {random.imie} {random.nazwisko}");


            List<Osoba> osoby = Enumerable.Range(1, 100).Select(x => new Osoba() {id = x, imie,)

            

        }
    }
}

    
