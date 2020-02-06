using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2_P3_Poprawa_6_luty
{
    class Hex
    {
        string kod;

        public Hex(out string r, out string g, out string b)
        {

            r = R;
            g = G;
            b = B;
        }

        public string R { get; set; }
        public string G { get; set; }
        public string B { get; set; }


    }
}
