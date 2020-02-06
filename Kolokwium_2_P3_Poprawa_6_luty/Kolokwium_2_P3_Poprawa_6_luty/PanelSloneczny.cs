using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2_P3_Poprawa_6_luty
{
    class PanelSloneczny : Interface1
    {
        public void Zasilaj(int energia)
        {
            DateTime data = DateTime.Today;
            
           if(energia < 100)
            {
                Console.WriteLine("ok");
            }
        }
       
    }
}
