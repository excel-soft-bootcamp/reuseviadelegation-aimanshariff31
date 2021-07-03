using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApp
{
    class Traveller
    {
        public void Hike(IGps gps)
        {

            gps.Navigate();
        }

    }
}