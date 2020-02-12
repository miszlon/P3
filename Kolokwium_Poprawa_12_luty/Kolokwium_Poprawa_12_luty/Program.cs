using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolokwium_Poprawa_12_luty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piosenka> playlista = new List<Piosenka>();
            playlista.Add(new Piosenka("Piosenka1", "Miłosz",new TimeSpan(0,3,30)));
            playlista.Add(new Piosenka("Piosenka2", "Miłosz2", new TimeSpan(0, 4, 30)));
            playlista.Add(new Piosenka("Piosenka3", "Miłosz3", new TimeSpan(0, 5, 30)));

            foreach(var i in playlista)
            {
                Console.WriteLine(i.Autor);
                Console.WriteLine(i.Dlugosc);
                Console.WriteLine(i.Tytul);
            }

            var dlugoscPlaylisty = new TimeSpan(playlista.Sum(r => r.Dlugosc.Ticks));

            Console.WriteLine(dlugoscPlaylisty);

            playlista.Sort();

            List<Piosenka> sortowaniePoTytule = playlista.OrderBy(x => x.Tytul).ToList();
            List<Piosenka> sortowaniePoAutorze = playlista.OrderBy(x => x.Autor).ToList();

            foreach(var i in sortowaniePoAutorze)
            {
                Console.WriteLine(i);
            }
            foreach(var i in sortowaniePoTytule)
            {
                Console.WriteLine(i);
            }





        }
    }
}
