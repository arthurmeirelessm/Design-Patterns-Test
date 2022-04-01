using Lsp.Client;
using Lsp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.TypeServiceOfCard
{
    internal class CreditCard : Card
    {

        public int ValueOfPayment;

        public CreditCard(int valueOfPayment)
        {
            this.ValueOfPayment = valueOfPayment;
        }

        public void Validate(int valueOfPayment)
        {
           
            Console.WriteLine("Validando o limite...");
            int limit = 1700;
            if (valueOfPayment < limit)
            {
                Console.WriteLine("Limite Ok!");
                CollectPayment();
            }
            else
            {
                Console.WriteLine("limite de cartão ultrapasssado");
                ErrorPayment();

            }
        }
    }
}
