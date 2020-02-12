using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Kolokwium_2_P3_Poprawa_6_luty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produkt> produkty = new List<Produkt>();

            produkty.Add(new Produkt());


        }

        


    }
    public static class IExtensions
    {
        public static string MyExtension(this string i,int liczba)
        {
            if (i.Length < liczba)
            {
                return i;
            }
            else
            {
                return i;
            }
        }
    }
}
