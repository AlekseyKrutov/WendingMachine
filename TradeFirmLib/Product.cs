using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public ProductType ProductType { get; set; }
        public string Articul { get; set; }
        public bool ActiveFlag { get; set; }
        public Product() {}
        public Product(string ProductName, ProductType ProductType, string Articul)
        {
            this.ProductName = ProductName;
            this.ProductType = ProductType;
            this.Articul = Articul;
            this.ActiveFlag = true;
        }
        public void DeactivateProduct()
        {
            this.ActiveFlag = false;
        }
    }
}
