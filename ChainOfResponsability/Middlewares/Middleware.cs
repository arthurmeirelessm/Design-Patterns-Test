using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    abstract internal class Middleware
    {
        private Middleware next;

        public Middleware LinkWith(Middleware next)
        {
            this.next = next;
            return next;
        }

        public abstract Boolean Check(string email, string password);
       
        protected Boolean CheckNext(string email, string password)
        {
            if (next == null)
            {
                return true;
            }

            return next.Check(email, password);
        }
         
        
    }
}
