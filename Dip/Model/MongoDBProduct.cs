
using Dip.Interfaces;
using Dip.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Model
{
    internal class MongoDBProduct : IDbProduct
    {
        public void GetProductById(int id)
        {
            Console.WriteLine($"MongoDB: Exibindo dados do produto { id}");
        }
    }
}
