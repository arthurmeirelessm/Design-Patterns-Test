using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platforms
{
    internal class FaceBook : IPlatform
    {
        public FaceBook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();    
            Console.WriteLine("Facebook: Configurando servidor RMTP");
        }
    }
}
