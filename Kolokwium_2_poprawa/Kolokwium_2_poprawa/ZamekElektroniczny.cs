using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2_poprawa
{
    class ZamekElektroniczny : IZamek
    {
        public static void KartaManget()
        {
            DateTime data = DateTime.Today;
            Console.WriteLine("Proszę przyłożyć kartę magnetyczną");
            Console.WriteLine("1 - przyłożenie, 0 - nieprzyłożył karty");
            int karta = int.Parse(Console.ReadLine());
            int licznikWejsc = 0;
            while (licznikWejsc < 2)
            {
                if (karta == 1)
                {
                    Console.WriteLine(data);
                    licznikWejsc++;
                }
                else Console.WriteLine("nie weszłeś!");
            }
            Console.WriteLine("Za dużo prób wejść");
        }
        public void Otworz()
        {

        }

        public void Zamknij()
        {

        }
    }
}
