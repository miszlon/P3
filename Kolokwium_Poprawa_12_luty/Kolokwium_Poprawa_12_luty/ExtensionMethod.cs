using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa_12_luty
{
    static class ExtensionMethod
    {
        public static int[] MetodaRoz(this int[] tablica)
        {
            int mnoznik = 10;
            for(int i = 0; i< tablica.Length;i++)
            {
                tablica[i] = tablica[i] * mnoznik;
            }

            return tablica;
        }
    }
}
