using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class Program
    {
        private static Server _server;

        static void Init()
        {
            _server = new Server();
            _server.RegisterUser("master@hcode.com.br", "12345678");
            _server.RegisterUser("user@hcode.com.br", "12344tascv");

            Middleware middleware = new CheckPermissionMiddleware();
            middleware.LinkWith(new CheckPermissionMiddleware());
            _server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            Boolean done;

            do
            {
                Console.WriteLine("Digite o seu email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite a sua senha: ");
                string password = Console.ReadLine();

                done = _server.Login(email, password);
            } while (!done);


                Console.ReadLine();
            

        }
    }
}
