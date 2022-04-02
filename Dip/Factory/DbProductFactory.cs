using Dip.Interfaces;
using Dip.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Factory
{
    internal class DbProductFactory
    {
        public void Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                SQLServerProduct sqlProduct = new SQLServerProduct();
                sqlProduct.GetProductById(2433);
            }
            else
            {

                MongoDBProduct mongoProduct = new MongoDBProduct();
                mongoProduct.GetProductById(2433);
            }
        }
    }
}
