using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    public static class ExtensionsMethods
    {  
        public static (int, int) DzielenieZReszta(this int liczba, int dzielnik)
        {

             return (liczba / dzielnik, liczba % dzielnik);
        }

        public static int CountingChars(this string tekst, char c)
        {
            int sum = 0;

            foreach (var item in tekst)
                if (item == c) sum++;

            return sum;
        }

        public static int CountingChars(this string tekst, char litera, bool caseInvariant)
        {
            int sum = 0;
            
            foreach (var item in tekst)
            {
                bool existLetter;
                if (caseInvariant)
                    existLetter = (item == litera);
                else
                    existLetter = (item == char.ToUpper(litera) || item == char.ToLower(litera));
            }
            return sum;
        }

        public static bool CzyDlaNiepelnoletnich(this PrzedzialWiekowy przedzial)
        {
            if (przedzial <= PrzedzialWiekowy.Mlodziez)
                return true;
            return false;
        }

    }
}
