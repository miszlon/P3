using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    [Flags]
    public enum PrzedzialWiekowy
    {
        Brak = 0,
        Dzieci = 1,
        Mlodziez = 2,
        Dorosli = 4,
        Starsi = 8
    }
    [Flags]
    public enum Zaintersowania
    {
        Brak = 0,
        Elektronika = 1,
        Motoryzacja = 2,
        Gaming = 4,
        Ekonomia = 8
    }
}
