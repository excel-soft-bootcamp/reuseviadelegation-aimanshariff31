using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApp
{
    class Phone : IPhone
    {
        public void Hangup()
        {
            Console.WriteLine("Call is disconnected");
        }
        public void Release()
        {
            Console.WriteLine("Call is connected");
        }
    }
}
