﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Interfaces
{
     interface IPaymentInstrument
    {
        void CollectPayment();
        void Validate();
    }
}
