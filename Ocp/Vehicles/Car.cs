using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicles
{
    internal class Car : Vehicle
    {
        private int Seats;
        private int Doors;

        public Car(string color, int year, double engine, int seats, int doors) : base(color, year, engine)
        {
            this.Seats = seats;
            this.Doors = doors;
        }


        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {Color}, {Year}, {Engine}, {Doors} portas e {Seats} assentos");
            StartVehicle();
        }

    }
}
