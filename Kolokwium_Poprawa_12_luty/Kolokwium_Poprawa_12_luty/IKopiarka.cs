using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa_12_luty
{
    interface IKopiarka : ISkaner, IDrukarka
    {
        string Kopiuj(string napis);
            
    }
}
