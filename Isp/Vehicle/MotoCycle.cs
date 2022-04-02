using Isp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicle
{
    internal class MotoCycle : IVehicleMotocycle
    {
        private string Color { get; set; }
        private int Year { get; set; }
        private double Engine { get; set; }

        public MotoCycle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;
        }

        public void ConfigureMotocycle(string color, int year, double engine)
        {

            Console.WriteLine($"Criando uma moto do ano de {year}, motor {engine} e na cor {color} ");
            StartingVehicleMotocycle();
        }

        public void StartingVehicleMotocycle()
        {
            Console.WriteLine("Ligando os motores da moto...");
        }
    }

}