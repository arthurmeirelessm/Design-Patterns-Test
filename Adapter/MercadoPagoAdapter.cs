using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class MercdoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

       
        public MercdoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando adaptação de pyonner para paypal");
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken(); 
        }

        public void PayPalPayment()
        {
            this.mercadoPago.MercadoPagoPayment();
        }

        public void PayPalReceive()
        {
           this.mercadoPago.MercadoPagoPayment();
        }
        public void PaymentService()
        {
            PayPalPayment();
            PayPalReceive();
        }
    }
}
