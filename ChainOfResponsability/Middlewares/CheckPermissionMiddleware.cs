using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    internal class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
           if (email.Equals("master@hcode.com.br"))
            {
                Console.WriteLine("Seja bem vindo ADM!");
                return true;
            }

            Console.WriteLine("Seja bem vindo!");

            return CheckNext(email, password);
        }
    }
}
