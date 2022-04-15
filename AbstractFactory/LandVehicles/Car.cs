using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    internal class Car : ILandVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("O(s) passageiro(s) já estão no carro!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto");
        }
    }
}
