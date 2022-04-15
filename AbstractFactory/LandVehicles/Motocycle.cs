using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    internal class Motocycle : ILandVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("O passageiro já está na moto!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto!");
        }
    }
}
