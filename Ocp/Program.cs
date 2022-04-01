using Ocp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
   class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle typeCar = TypeVehicle.CAR;
            TypeVehicle typeMotocycle = TypeVehicle.MOTOCYCLE;

            Console.WriteLine("how would you assemble your vehicle?");
            string typeInput = Console.ReadLine();
            if (typeCar == TypeVehicle.CAR && typeInput == "CAR" || typeInput == "Car") 
            {
                Car carVehicle = new Car("Preto", 2022, 2.0, 5, 4);
                carVehicle.ConfigureCar();
            }
            else if (typeMotocycle == TypeVehicle.MOTOCYCLE && typeInput == "Motocycle" || typeInput == "motocycle")
            {
                Motocycle motoCycleVehicle = new Motocycle("Preto", 2022, 2.0, 5, 0);
                motoCycleVehicle.ConfigureMotocycle();
            }
            else
            {
                Console.WriteLine("Only vehicles");
            } 

            Console.ReadLine();

        }
    }
}
