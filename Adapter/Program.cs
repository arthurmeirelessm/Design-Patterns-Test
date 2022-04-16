using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPayPalPayment payment = new MercdoPagoAdapter(new MercadoPago());
    
                payment.PaymentService();
               
        }
    }
}
