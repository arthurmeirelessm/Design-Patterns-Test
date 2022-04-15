using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
    internal class Application
    {
        private IAircraft aircraft;
        private ILandVehicles landVehicles;

        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateTransportAircraft();
            landVehicles = factory.CreateTransportLandVehicles();
            
        }


        public void StartRoute()
        {
            landVehicles.StartRoute();
            aircraft.StartRoute();
        }

    }
}
