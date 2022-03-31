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
            TypeVehicle type = TypeVehicle.CAR;
            Console.WriteLine("how would you assemble your vehicle?");
            string typeInput = Console.ReadLine();
            if (type == TypeVehicle.CAR && typeInput == "CAR") 
            {
                Vehicle carVehicle = new Vehicle("Preto", 2022, 2.0, 5, 4);
                carVehicle.Car();
            }
            else
            {
                Vehicle motoCycleVehicle = new Vehicle("Preto", 2022, 2.0, 5, 0);
                motoCycleVehicle.Motocycle();
            }


        }
    }
}
