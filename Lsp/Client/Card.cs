using Lsp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Client
{
    abstract class Card : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado");
        }


        public void ErrorPayment()
        {
            Console.WriteLine("Pagamento NÃO foi realizado");
        }




        public virtual void Validate()
        {
           //Validação básica do cartão (se é debito ou credito) 
        }
    }
}
