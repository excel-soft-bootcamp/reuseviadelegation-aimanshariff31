using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera _camera = new Camera();
            GPS __gps = new GPS();
            Phone _phone = new Phone();
            SmartPhone _smartPhone = new SmartPhone();
            _smartPhone.SetCamera(_camera);
            _smartPhone.SetNavigate(__gps);
            _smartPhone.SetPhone(_phone);


            Photographer _photographer = new Photographer();
            _photographer.Capture(_smartPhone);

            Traveller _travell = new Traveller();
            _travell.Hike(_smartPhone);

            Person _person = new Person();
            _person.Communicate(_smartPhone);

        }
    }
}
