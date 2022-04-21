using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    internal class CheckUserMiddleware : Middleware
    {


        private Server _servers;

        public CheckUserMiddleware(Server servers)
        {
            _servers = servers;
        }

        public override bool Check(string email, string password)
        {
            if (!_servers.HasEmail(email))
            {
                Console.WriteLine("Email invalido!");
                return false;
            }

            else if (!_servers.IsValidPassword(email, password))
            {
                Console.WriteLine("Senha invalida!");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
