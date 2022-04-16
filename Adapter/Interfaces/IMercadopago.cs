﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Interfaces
{
    internal interface IMercadopago
    {
        Token AuthToken();
        void MercadoPagoPayment();
        void MercadoPagoReceive();
        void PaymentService();
    }
}
