using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApp
{
    class SmartPhone : ICamera, IGps, IPhone
    {
        ICamera _camera;
        IGps _gps;
        IPhone _phone;
        public void SetCamera(ICamera camera)
        {
            this._camera = camera;
        }
        public void SetNavigate(IGps gps)
        {
            this._gps = gps;
        }
        public void SetPhone(IPhone phone)
        {
            this._phone = phone;
        }
        public void Click()
        {
            this._camera.Click();
        }
        public void Navigate()
        {
            this._gps.Navigate();

        }
        public void Hangup()
        {
            this._phone.Hangup();
        }
        public void Release()
        {
            this._phone.Release();
        }
    }
}
