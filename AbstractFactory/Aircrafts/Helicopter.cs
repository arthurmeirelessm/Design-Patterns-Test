using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal class Helicopter : IAircraft
    {
        public void CheckWind()
        {

            Console.WriteLine("Verificando os ventos, ventos a 25KM, ventos Ok");

        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiro(s) já estão a bordo!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Vamos decolar.");
        }
    }
}
