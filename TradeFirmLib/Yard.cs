using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public class Yard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<ProductQuantity> Products { get; set; }
        public Yard(string Name, string Address, List<ProductQuantity> Products)
        {
            this.Name = Name;
            this.Address = Address;
            this.Products = Products;
        }
        virtual public void PushProduct(Product product) { }
        virtual public void PushProducts(List<Product> products) { }
        virtual public void PopProduct(Product product) { }
        virtual public void PopProducts(List<Product> products) { }
    }
}
