using Isp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicle
{
    internal class Car : IVehicleCar
    {
        private string Color;
        private int Year;
        private double Engine;
        private int Seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
           Color = color;
            Year = year;
           Engine = engine;
            Seats = seats;
            doors = doors;
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
             
             Console.WriteLine($"Criando carro ano {year}, motor {engine}, da cor {color}");
             StartingVehicleCar(); 
        }
        public void StartingVehicleCar()
        {
            Console.WriteLine("Ligando os motores do carro...");
        }
    }
}
