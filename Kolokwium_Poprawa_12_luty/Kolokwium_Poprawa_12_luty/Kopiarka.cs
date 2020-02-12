using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa_12_luty
{
    class Kopiarka : IKopiarka
    {
        public void Skanuj()
        {

        }

        public void Drukuj(string napis)
        {

        }

       

        string ISkaner.Skanuj()
        {
            throw new NotImplementedException();
        }

        public string Kopiuj(string napis)
        {
           return Kopiuj(napis);

        }
    }
}
