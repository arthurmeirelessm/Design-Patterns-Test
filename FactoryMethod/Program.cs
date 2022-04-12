using FactoryMethod.AbstractClass;
using FactoryMethod.Factories;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What service tour choose?");
            string typeService = Console.ReadLine();

            // A grande ideia do transport abaixo é:
            //Setar uma classe com metodos onde suas derivadas usariam a mesma ação
            Transport transport = null;
            
          
            if (typeService == "Uber")
            {

              transport = new CarTransport();
                Console.WriteLine(transport);
                transport.StartTransport();
             
            }
            else if (typeService == "Motocycle")
            {
                transport = new MotocycleTransport();
                transport.StartTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo do serviço.");
            }

            Console.ReadLine();
        }
    }
}
