using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2_P3_Poprawa_6_luty
{
    static class ExtensionMethod
    {
        public static int Policz(this String s, char c)
        {
            int counter = 0;
            
            foreach(var it in s)
            {
                if(it == c)
                {
                    counter++;
                }

            }
            return counter;
        }
    }
}
