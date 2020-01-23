using System;
using System.Collections.Generic;
using System.Text;

namespace lab_ix
{
    public static class ExtensionsMethods
    {
        public static bool hasForChild(this PrzedzialWiekowy przedzialWiekowy)
        {
            return (przedzialWiekowy <= PrzedzialWiekowy.Mlodziez);

        }
        public static (int, int) DzielenieZReszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
        }

        public static int LetterCounter(this string str, char c, bool sensitive)
        {

            int sum = 0;

            foreach (var item in str)
            {
                bool existsLetter;

                if (sensitive || !char.IsLetter(c))
                    existsLetter = (item == c);
                else
                    existsLetter = (item == char.ToUpper(c) || item == char.ToLower(c));


                if (existsLetter)
                    sum++;
            }

            return sum;
        }

        public static int LetterCounter(this string str, char c)
        {
            return LetterCounter(str, c, false);
        }
    }
}
