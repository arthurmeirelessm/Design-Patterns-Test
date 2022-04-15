using AbstractFactory.Aircrafts;
using AbstractFactory.App;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Application app;

            ITransportFactory transportFactory;
            Console.WriteLine("Escolha a compania que deseja: ");

            string company = Console.ReadLine(;

            if (company == "Uber")
            {
                transportFactory = new UberTransport();
                Console.WriteLine("Qual tipo de serviço você quer ter?");
                string serviceNameUber = Console.ReadLine();
                if (serviceNameUber == "Helicopter" || serviceNameUber == "Airplane" || serviceNameUber == "Aéreo")
                {
                    int windValue = 29;
                    Console.WriteLine($"A velocidade do vento é de {windValue}");
                    Console.WriteLine();
                    Console.WriteLine();
                    transportFactory.CreateTransportAircraft();
                }
                else if (company == "Car" || company == "Motocycle" || company == "Térreo")
                {
                    transportFactory.CreateTransportLandVehicles();
                }
            }
            else if (company == "99")
            {
                transportFactory = new _99Transport();
                Console.WriteLine("Qual tipo de serviço você quer ter?");
                string serviceName99 = Console.ReadLine();
                if (serviceName99 == "Helicopter" || serviceName99 == "Airplane" || serviceName99 == "Aéreo")
                {
                    int windValue = 29;
                    Console.WriteLine($"A velocidade do vento é de {windValue}");
                    Console.WriteLine();
                    Console.WriteLine();
                    transportFactory.CreateTransportAircraft();
                }
                else if (company == "Car" || company == "Motocycle" || company == "Térreo")
                {
                    transportFactory.CreateTransportLandVehicles();
                }

            }
            else
            {
                Console.WriteLine("Os serviõs disponíveis são uber ou 99, escolha um desses");
            }

        }
    }
}
