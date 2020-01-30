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
            if(karta ==1)
            {
                Console.WriteLine(data);
            }
            else Console.WriteLine("nie weszłeś!");
        }
        public void Otworz()
        {

        }

        public void Zamknij()
        {

        }
    }
}
