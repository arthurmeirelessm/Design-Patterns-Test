using Bridge.Interfaces;
using Bridge.Platforms;
using Bridge.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");
            
            Live live = new Live(platform);
            live.Broadcasting();
            live.Result();

        }
        static void OnlyLegends(IPlatform platform)
        {
            Console.WriteLine("Tranquilo!");

            Advancedlive advancedlive = new Advancedlive(platform);
            advancedlive.Subtitle();
        }

        static void LegendsAndComments(IPlatform platform)
        {
            Console.WriteLine("Tranquilo!");

            Advancedlive advancedlive = new Advancedlive(platform);
            advancedlive.CommentsAndSubtitles();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Em qual plataforma voce quer assitir? ");
            string userChoose = Console.ReadLine();
            if (userChoose == "Youtube")
            {
                StartLive(new Youtube());
                Console.WriteLine("Deseja somente legendas ou legendas e comentários liberados?");
                string ChosseAdvancedlive = Console.ReadLine();
                if (ChosseAdvancedlive == "Somente legendas")
                {
                   OnlyLegends(new Youtube());

                } else if (ChosseAdvancedlive == "Legendas e comentários liberados")
                {
                    LegendsAndComments(new Youtube());
                }
                else if (ChosseAdvancedlive == "Nenhum" || ChosseAdvancedlive == "Nenhum dos dois")
                {
                    Console.WriteLine("Ok, Seguindo com a transmissão!");
                }
                
            }
            else if (userChoose == "FaceBook") {
                StartLive(new FaceBook());
                Console.WriteLine("Deseja somente legendas ou legendas e comentários liberados?");
                string ChosseAdvancedlive = Console.ReadLine();
                if (ChosseAdvancedlive == "Somente legendas")
                {
                    OnlyLegends(new FaceBook());
                }
                else if (ChosseAdvancedlive == "Legendas e comentários liberados")
                {
                    LegendsAndComments(new FaceBook());
                }
                else if (ChosseAdvancedlive == "Nenhum" || ChosseAdvancedlive == "Nenhum dos dois")
                {
                    Console.WriteLine("Ok, Seguindo com a transmissão!");
                }
            }
            else
            {
                StartLive(new TwitchTV());
                Console.WriteLine("Deseja somente legendas ou legendas e comentários liberados?");
                string ChosseAdvancedlive = Console.ReadLine();
                if (ChosseAdvancedlive == "Somente legendas")
                {
                    OnlyLegends(new TwitchTV());

                }
                else if (ChosseAdvancedlive == "Legendas e comentários liberados")
                {
                    LegendsAndComments(new TwitchTV());
                }
                else if (ChosseAdvancedlive == "Nenhum" || ChosseAdvancedlive == "Nenhum dos dois")
                {
                    Console.WriteLine("Ok, Seguindo com a transmissão!");
                }
            }
            
        }
    }
}
