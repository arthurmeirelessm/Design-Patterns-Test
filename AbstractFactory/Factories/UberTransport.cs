using AbstractFactory.Aircrafts;
using AbstractFactory.Interfaces;
using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace AbstractFactory.Factories
{
    internal class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();

        }

        public ILandVehicles CreateTransportLandVehicles()
        {
            return new Car();
        }
    }
}
