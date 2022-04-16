using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PyonnerAdapter : IPayPalPayment
    {
        private Pyonner pyonner;

       
        public PyonnerAdapter(Pyonner pyonner)
        {
            this.pyonner = pyonner;
            Console.WriteLine("Realizando adaptação de pyonner para paypal");
        }

        public Token AuthToken()
        {
            return this.pyonner.AuthToken(); 
        }

        public void PayPalPayment()
        {
            this.pyonner.PyonnerPayment();
        }

        public void PayPalReceive()
        {
           this.pyonner.PyonnerReceive();
        }
        public void PaymentService()
        {
            PayPalPayment();
            PayPalReceive();
        }
    }
}
