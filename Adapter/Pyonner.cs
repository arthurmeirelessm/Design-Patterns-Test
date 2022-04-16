using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Pyonner : IPyonnerPayment
    {

        private Token token;
        public Token AuthToken()
        {
            return new Token(); 
        }

        public void PyonnerPayment()
        {
          token = AuthToken();
            Console.WriteLine("Enviando pagamentos com Pyonner");
        }

        public void PyonnerReceive()
        {
            Console.WriteLine("Recebendo pagamentos com Pyonner");
        }

        public void PaymentService ( )
        {
            PyonnerPayment();
            PyonnerReceive();
        }
    }
}
