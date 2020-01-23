using System;
using System.Collections.Generic;
using System.Text;

namespace lab_ix
{
    class Reklama
    {
        public string Tekst;
        public PrzedzialWiekowy PrzedzialWiekowy;
        public Zainteresowania Zainteresowania;

        public Reklama(string tekst, PrzedzialWiekowy przedzialWiekowy, Zainteresowania zainteresowania)
        {
            Tekst = tekst;
            PrzedzialWiekowy = przedzialWiekowy;
            Zainteresowania = zainteresowania;
        }

        public void Test()
        {
            if (PrzedzialWiekowy.HasFlag(PrzedzialWiekowy.Dzieci))
                Console.WriteLine("Reklama dla dzieci");

            if (PrzedzialWiekowy >= PrzedzialWiekowy.Dorosli)
                Console.WriteLine("Reklama dla dorosłych");
        }
    }
}