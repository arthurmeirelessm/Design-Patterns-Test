using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissions
{
        internal class Live : ITransmission
        {

            protected IPlatform platform;

            public Live(IPlatform platform)
            {
                this.platform = platform;
            }

            public void Broadcasting()
            {
                Console.WriteLine($"Iniciando a transmissão na plataforma {platform}");
            }

            public void Result()
            {
                Console.WriteLine("**** ON AIR ****");
            }
        }
    }
