using Lsp.Client;
using Lsp.TypeServiceOfCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What card of digital bark are you going to use ?");
            string nameCard = Console.ReadLine();
            if (nameCard == "Nubank" || nameCard == "Neon" || nameCard == "Inter")
            {
                
                Console.WriteLine("Is debit or credit?");
                string debitOrCredit = Console.ReadLine();
                if (debitOrCredit == "Credit")
                {

                    int valueOfPayment = 12343;
                    Console.WriteLine($"O valor da sua compra deu {valueOfPayment}");
                    CreditCard creditCard = new CreditCard(valueOfPayment);
                    creditCard.Validate(valueOfPayment);
                   

                    Console.ReadLine();
                }

                else if (debitOrCredit == "Debit")
                {
                    int valueOfPayment = 12343;
                    Console.WriteLine($"O valor da sua compra deu {valueOfPayment}");
                    DebitCard debitCard = new DebitCard(valueOfPayment);
                    debitCard.Validate(valueOfPayment);
                    

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Choose if is Debit or credit");
                }
            }
            else
                Console.WriteLine("this card is not a digital bank");
             
        }
    }
}
