using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApp
{
    class Person
    {
        public void Communicate(IPhone _phone)
        {

            _phone.Hangup();
            _phone.Release();
        }
    }
}