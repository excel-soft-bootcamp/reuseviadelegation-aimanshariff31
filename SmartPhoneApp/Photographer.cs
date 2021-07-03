using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApp
{
    class Photographer
    {
        public void Capture(ICamera camera)
        {
            camera.Click();
        }
    }
}
