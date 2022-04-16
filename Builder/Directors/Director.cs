using Builder.Builders;
using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    internal class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }


        public void ConstructSedanCar()
        {
            
            builder.SetVehicle(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(4);
            builder.SetTrasmission(Transmission.AUT);
           

        }
        public void ConstructTruck()
        {
            builder.SetVehicle(VehicleType.TRUCK);
            builder.SetEngine(new Engine(6700));
            builder.SetSeats(4);
            builder.SetTrasmission(Transmission.MANUAL);
        }

    }
}
