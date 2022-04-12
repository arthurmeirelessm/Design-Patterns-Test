using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    internal class Car : IVehicles

    {
        public void GetCarg()
        {
            Console.WriteLine("O carro acabou de pegar os passageiros!");
        }

        public void StartRoute()
        {
            GetCarg();
            Console.WriteLine("Iniciamos o trajeto.");
        }
    }
}
