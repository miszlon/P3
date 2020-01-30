using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2_poprawa
{
    class Mieszkanie
    {
        public Mieszkanie(int metraz, string nazwa, int odlegloscOdCentrum)
        {
            Metraz = metraz;
            Nazwa = nazwa;
            OdlegloscOdCentrum = odlegloscOdCentrum;
        }

        public int Metraz { set; get; }
        public string Nazwa { get; set; }
        public int OdlegloscOdCentrum { get; set; }

    }
}
