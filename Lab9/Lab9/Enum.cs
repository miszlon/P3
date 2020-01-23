using System;
using System.Collections.Generic;
using System.Text;

namespace lab_ix
{
    [Flags]
    public enum PrzedzialWiekowy
    {
        Dzieci = 1,
        Mlodziez = 2,
        Dorosli = 4,
        Starsi = 8
    }

    [Flags]
    public enum Zainteresowania
    {
        Elektronika = 1,
        Motoryzacja = 2,
        Gaming = 4,
        Ekonomia = 8
    }
}
