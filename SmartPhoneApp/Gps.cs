using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApp
{
    class GPS : IGps
    {
        public void Navigate()
        {
            Console.WriteLine("Navigated by Gps");
        }
    }
}

