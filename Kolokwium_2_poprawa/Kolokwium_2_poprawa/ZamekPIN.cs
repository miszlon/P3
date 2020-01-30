using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2_poprawa
{
    class ZamekPIN : IZamek
    {
        
        public static void KodDostepu()
        {
            Console.WriteLine("Prosze o podanie kodu dostępu (4 cyfry)");
            int kod = int.Parse(Console.ReadLine());
            if(kod == 1234)
            {
                Console.WriteLine("Udało Ci sie wejść");
            }
            Console.WriteLine("Błędny kod");
                       
        }
        public ZamekPIN(int kod)
        {
            Kod = kod;
        }

        public int Kod { get; set; }

        public void Otworz()
        {
            Console.WriteLine("jesteś w środku");
        }

        public void Zamknij()
        {
            Console.WriteLine("Drzwi zamknięte");
        }

    }
}
