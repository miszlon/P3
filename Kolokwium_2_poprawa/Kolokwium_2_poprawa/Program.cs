using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolokwium_2_poprawa
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------ZADANIE 1-----------------
            Random rand = new Random();
            List<Mieszkanie> mieszkania = new List<Mieszkanie>();


            for(int i = 0; i < 50; i++)
            {
                mieszkania.Add(new Mieszkanie(rand.Next(1, 50), "dom" ,rand.Next(2, 20000)));
            }

            //--------ZADANIE 4-------------------
            ZamekPIN.KodDostepu();
            ZamekElektroniczny.KartaManget();

            List<IZamek> zamek = new List<IZamek>();
            
        }
    }
}
