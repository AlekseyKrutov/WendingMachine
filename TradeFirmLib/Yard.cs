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
        public bool ActiveFlag { get; set; }
        public IList<ProductYard> ProdYard { get; set; }
        public Yard() { }
        public Yard(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
            this.ActiveFlag = true;
        }
        virtual public bool DeleteProductFromyYard(ProductQuantity pq)
        {
            bool canDelete = false;
            ProductYard py = ProdYard.Select(p => p).Where(p => p.Product == pq.Product).FirstOrDefault();
            if (py != null && py.Product == pq.Product
                    && py.Quantity >= pq.Quantity)
            {
                canDelete = true;
                py.Quantity -= pq.Quantity;
                return canDelete;
            }
            return canDelete;
        }
        virtual public void AddProductInYard(ProductQuantity pq, Supply supply)
        {
            ProductYard py = ProdYard.Select(p => p).Where(p => p.Product == pq.Product).FirstOrDefault();
            if (py != null)
            {
                py.Quantity += pq.Quantity;
                py.Supply = supply;
            }
            else
            {
                ProdYard.Add(new ProductYard { Product = pq.Product, Quantity = pq.Quantity, Supply = supply, Yard = this });
            }
        }
        virtual public void PushProducts(List<Product> products) { }
        virtual public void PopProducts(List<Product> products) { }
    }
}
