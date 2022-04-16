using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class VehicleBuilder : IBuilder
    {

        private Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
           Vehicle result = vehicle; 
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
            Console.WriteLine("resetado");
        }

        public void SetEngine(Engine engine)
        {
          vehicle.Engine = engine;
        }   

        public void SetSeats(int seats)
        {
            vehicle.Seats = seats;
        }

        public void SetTrasmission(Transmission trasmission)
        {
           vehicle.Transmission = trasmission;
        }

        public void SetVehicle(VehicleType vehicleType)
        {
            vehicle.VType = vehicleType;
        }
    }
}
