using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Interfaces
{
    internal class MercadoPago : IMercadopago
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void MercadoPagoPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com MercadoPago");
        }

        public void  MercadoPagoReceive()
        {
            Console.WriteLine("Recebendo pagamentos com MercadoPago ");
        }
        public void PaymentService()
        {
            MercadoPagoPayment();
            MercadoPagoReceive();
        }
    }
}
