using Isp.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what type vehicle:");
            string typeVehicle = Console.ReadLine();
            if (typeVehicle == "Car")
            {
                Console.WriteLine("Now, define your model of Car");
                Console.WriteLine("Color: ");
                string color = Console.ReadLine();
                Console.WriteLine("Engine: ");
                double engine = double.Parse(Console.ReadLine());
                Console.WriteLine("Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Seats: ");
                int seats = int.Parse(Console.ReadLine());
                Console.WriteLine("Doors: ");
                int doors = int.Parse(Console.ReadLine());

                Car car = new Car(color, year, engine, seats, doors);
                car.ConfigureCar(color, year, engine, seats, doors);
            }

            else if (typeVehicle == "Motocycle")
            {
                Console.WriteLine("Now, define your model of Motocycle");
                Console.WriteLine("Color: ");
                string color = Console.ReadLine();
                Console.WriteLine("Engine: ");
                double engine = double.Parse(Console.ReadLine());
                Console.WriteLine("Year: ");
                int year = int.Parse(Console.ReadLine());

                MotoCycle motoCycle = new MotoCycle(color, year, engine);
                motoCycle.ConfigureMotocycle(color, year, engine);
            }
        }
    }
}
