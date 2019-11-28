using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public class Supply
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime SupplyDate { get; set; }
        public bool ActiveFlag { get; set; }
        public Employee StockMan { get; set; }
        public IList<Product> Products { get; set; }
        public Supply(Supplier Supplier, Employee StockMan, 
            List<Product> Products, DateTime? SupplyDate = null)
        {
            this.Supplier = Supplier;
            this.StockMan = StockMan;
            this.ActiveFlag = true;
            this.Products = Products;
            this.SupplyDate = (SupplyDate == null) ? DateTime.Now : (DateTime) SupplyDate;
        }
        public void CloseSupply() { }
        public void CancelSupply() { }
        public void PayOffSupply() { }
        public void SupplyProductsInMachine() { }
    }
}
