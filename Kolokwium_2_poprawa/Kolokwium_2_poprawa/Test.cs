using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2_poprawa
{
    class Test
    {
        public void Deconstruct(out int x, out bool y)
        {
            x = ID;
            y = Powodzenie;
        }

        public void Deconstruct(out int id, out string nazwa, out string opis, out bool powodzenie, out string tester)
        {
            id = ID;
            nazwa = Nazwa;
            opis = Opis;
            powodzenie = Powodzenie;
            tester = Tester;
        }

        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public bool Powodzenie { get; set; }
        public string Tester { get; set; }

    }
}
