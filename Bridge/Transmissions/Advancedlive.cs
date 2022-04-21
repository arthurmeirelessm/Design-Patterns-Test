using Bridge.Interfaces;
using Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissions
{
    internal class Advancedlive : Live
    {
        public Advancedlive(IPlatform platform) : base(platform)
        {

        }

        public void Subtitle()
        {
            Console.WriteLine("legendas ativadas na transmissão");
        }

        public void CommentsAndSubtitles()
        {
            Subtitle();
            Console.WriteLine("Comentarios liberados na live");
        }

    }
}
