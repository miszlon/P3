using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa_12_luty
{
    class Piosenka
    {
        public Piosenka(string tytul, string autor, TimeSpan dlugosc)
        {
            Tytul = tytul;
            Autor = autor;
            Dlugosc = dlugosc;
        }

        public string Tytul { get; set; }
        public string Autor { get; set; }
        public TimeSpan Dlugosc { get; set; }

    }
}
