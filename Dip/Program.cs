using Dip.Factory;
using Dip.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbProductFactory productFactory = new DbProductFactory();
            productFactory.Create();

            Console.ReadLine();
            
        }
    }
}
