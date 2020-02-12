using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa_12_luty
{
    class Cytat
    {
        public string Autor { get; set; }
        public string Tytul { get; set; }
        public DateTime DataWydania { get; set; }
        public string MiejsceWydania { get; set; }
        public string Wydawnictwo { get; set; }

        
        public void Deconstruct(out string autor, out int dataWydania)
        {
            autor = Autor;
            dataWydania = DataWydania.Year;
        }

        public void Deconstruct(out string tytul, out string autor, out string miejsce, out string wydawnictwo, out int dataWydania)
        {
            tytul = Tytul;
            autor = Autor;
            wydawnictwo = Wydawnictwo;
            miejsce = MiejsceWydania;
            dataWydania = DataWydania.Year;
        }

    }
}
