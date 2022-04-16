using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Interfaces
{
    internal interface IPyonnerPayment
    {
        Token AuthToken();
        void PyonnerPayment();
        void PyonnerReceive();

        void PaymentService();


    }
}
