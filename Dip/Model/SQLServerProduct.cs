using Dip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Model
{
    internal class SQLServerProduct : IDbProduct
    {

        public void GetProductById(int id)
        {
            Console.WriteLine($"SQLServer: Exibindo dados do produto { id}");
        }
    }
}
