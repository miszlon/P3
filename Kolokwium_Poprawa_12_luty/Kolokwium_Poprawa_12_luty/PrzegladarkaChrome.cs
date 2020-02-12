using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa_12_luty
{
    class PrzegladarkaChrome
    {
        int licznik = 0;

        public void WypiszLicznik(object sender, EventArgs e)
        {
            licznik++;
            Console.WriteLine("Gmail<{0}", licznik);
        }
    }
}
