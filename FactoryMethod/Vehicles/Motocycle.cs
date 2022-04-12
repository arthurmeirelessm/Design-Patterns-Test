using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    internal class Motocycle : IVehicles
    {
        public void GetCarg()
        {
            Console.WriteLine("A moto acabou de pegar a encomenda!");
        }

        public void StartRoute()
        {
            GetCarg();
            Console.WriteLine("Iniciamos a trajetoria.");
        }
    }
}
