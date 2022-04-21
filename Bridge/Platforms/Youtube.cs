using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platforms
{
    internal class Youtube : IPlatform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
           AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP");
        }
    }
}
