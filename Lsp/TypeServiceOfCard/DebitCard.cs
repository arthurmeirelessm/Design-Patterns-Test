using Lsp.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.TypeServiceOfCard
{
    internal class DebitCard : Card
    {

        
        public int ValueOfPayment;

        public DebitCard(int valueOfPayment)
        {
            
            ValueOfPayment = valueOfPayment;
        }

        public  void Validate(int valueOfPayment)
        {

            Console.WriteLine("Validando se você tem saldo na conta...");
            int saldo = 2600;
            if (valueOfPayment < saldo)
            {
                Console.WriteLine("Compra realizada!");
                CollectPayment();
            }
            else
            {
                Console.WriteLine("Saldo de cartão insuficiente");
                ErrorPayment();
            }
        }
    }
}
