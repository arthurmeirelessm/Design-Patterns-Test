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

        static Application ConfigureApplication()
        {
            ITransportFactory transportFactory;

            string company = "99";
            if (company == "Uber")
            {
                transportFactory = new UberTransport();
            }
            else
            {
                transportFactory = new _99Transport();
            }


            Application app = new Application(transportFactory);
            return app;
        }

        static void Main(string[] args)
        {

            Application app = ConfigureApplication();
            app.StartRoute();
            Console.ReadLine();
        }
    }
}
