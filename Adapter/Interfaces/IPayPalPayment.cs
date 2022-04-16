using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Interfaces
{
    internal interface IPayPalPayment
    {
        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();
        void PaymentService();
       
    }
}
