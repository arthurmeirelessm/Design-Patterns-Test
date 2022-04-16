using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
    internal class Vehicle
    {
        private VehicleType vType;
        private int seats;
        private Engine engine;
        private Transmission transmission;

      public VehicleType VType
        {
            get => vType;
            set => vType = value;
        }

        public int Seats
        {
            get => seats;
            set => seats = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Transmission Transmission 
        {
            get => transmission;
            set => transmission = value;
        }


    }
}
