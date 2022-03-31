using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
     class Vehicle
    {
        private string Color { get; set; }
        private int Year { get; set; }
        private double Engine { get; set; }
        private int Seats { get; set; }
        private int Doors { get; set; }

        public Vehicle(string color, int year, double engine, int seats, int doors)
        {
            this.Color = color;
            this.Year = year;
            this.Engine = engine;
            this.Seats = seats;
            this.Doors = doors;
        }

        public void Car()
        {
            Console.WriteLine($"Criando um carro {Color}, {Year}, {Engine}, {Doors} portas e {Seats} assentos");
            StartVehicle();

        }

        public void Motocycle()
        {
            Console.WriteLine($"Criando uma moto {Color}, {Year}, {Engine} cilindradas e {Seats} assentos");
            StartVehicle();
        }
        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores");
        }
    }
}
