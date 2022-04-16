using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Components
{
    internal class Engine
    {
        private int power;

       
        public int Power {
            get => power;
            set => power = value; }

        public Engine(int power)
        {
            this.Power = power;
        }
    }
}
