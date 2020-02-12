using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa_12_luty
{
    class Poczta
    {
        public event EventHandler NowyMail;


        public void Nadawca()
        {
            NowyMail.Invoke(this, EventArgs.Empty);
        }

        public void SkrotTresci()
        {
            NowyMail.Invoke(this, EventArgs.Empty);
        }


    }
}
