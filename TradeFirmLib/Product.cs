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
        public const int TaxPercent = 20;
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Supplier Supplier { get; set; }
        public Supply Supply { get; set; }
        public ProductType ProductType { get; set; }
        public decimal Cost { get; set; }
        public bool ActiveFlag { get; set; }
        public Product(string ProductName, Supplier Supplier, Supply Supply,
            ProductType ProductType, decimal Cost, bool AddTax = false)
        {
            this.ProductType = ProductType;
            this.Supplier = Supplier;
            this.Supply = Supply;
            this.ProductType = ProductType;
            this.Cost = (AddTax) ? AddTaxSum(Cost) : Cost;
        }
        public decimal AddTaxSum(decimal cost) => cost + (cost * (TaxPercent / 100));
        public DateTime CalculateFinishDate(Product p)
        {
            return p.Supply.SupplyDate.AddDays(p.ProductType.ShiftLifeDays);
        }
        public void DeactivateProduct()
        {
            this.ActiveFlag = false;
        }
    }
}
