using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class Reklama
    {
        public string Tekst;
        public PrzedzialWiekowy przedzialWiekowy;
        public Zaintersowania zainteresowania;

        public Reklama(string tekst, PrzedzialWiekowy przedzialWiekowy, Zaintersowania zainteresowania)
        {
            Tekst = tekst;
            this.przedzialWiekowy = przedzialWiekowy;
            this.zainteresowania = zainteresowania;
        }

        public void Commercial()
        {
            if (przedzialWiekowy.HasFlag(PrzedzialWiekowy.Dzieci))
                Console.WriteLine("Reklama dla Dzieci");

            if(przedzialWiekowy >= PrzedzialWiekowy.Dorosli)
                Console.WriteLine("Reklama dla Dorosłych");
        }
    }
}
