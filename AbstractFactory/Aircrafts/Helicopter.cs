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
        public int wind { get; set; }

        public Helicopter(int wind)
        {
            this.wind = wind;
        }

        public Helicopter()
        {
        }

        public void CheckWind()
        {

            Console.WriteLine("Verificando os ventos, ventos a 25KM, ventos Ok");

        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiro(s) já estão a bordo!");
        }

        public void StartRoute(int wind)
        {
            if (wind > 25)
            {
                CheckWind();
            }
            else
            {
                Console.WriteLine("Ventos ainda não favoráveis para voo, aguardando..");
            }

            GetCargo();
            Console.WriteLine("Vamos decolar.");
        }
    }
}
