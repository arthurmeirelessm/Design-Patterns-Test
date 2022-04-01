using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicles
{
       internal class Motocycle : Vehicle
        {


            public Motocycle(string color, int year, double engine, int seats, int doors) : base(color, year, engine)
            {
            
            }


            public void ConfigureMotocycle()
            {
                Console.WriteLine($"Criando uma moto {Color}, {Year}, {Engine} cilindradas");
                StartVehicle();
            }

        }
    }
