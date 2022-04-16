using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder vb = new VehicleBuilder();
            Director director = new Director(vb);

            
           
            director.ConstructSedanCar();
           
            Vehicle sedan = vb.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {sedan.VType}");

            Console.WriteLine("Deseja criar outro tipo de veículo?");

            string lastChoose = Console.ReadLine();

            if (lastChoose == "Sim")
            {
                vb.Reset();
                director.ConstructTruck();
                Vehicle truck = vb.GetVehicle();
                Console.WriteLine($"Criado um veiculo do tipo: {truck.VType}");
            }
            else
            {
                Console.WriteLine("Obrigado! Até logo.");
            }
            
        }
    }
}
