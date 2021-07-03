using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApp
{
    public class Camera : ICamera
    {
        public void Click()
        {
            Console.WriteLine("A click by camera");
        }
    }
}