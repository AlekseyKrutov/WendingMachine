using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradeFirmLib
{
    public class ProductQuantity
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Supply Supply { get; set; }
        public decimal Cost { get; set; }
        //стоимость с налогами
        public decimal RealCost { get; set; }
        public IList<Yard> Yards{ get; set; }
        public ProductQuantity() {}
        public ProductQuantity(Product Product, int Quantity, decimal Cost)
        {
            this.Product = Product;
            this.Quantity = Quantity;
            this.Cost = Cost / Quantity;
            this.RealCost = this.Cost + (this.Cost * (decimal) Constants.Tax) + (this.Cost * (decimal)Constants.AddingPercentage);
        }
        public ProductQuantity(Product Product, int Quantity, decimal Cost, Supply Supply, List<Yard> Yards)
            : this(Product, Quantity, Cost)
        {
            this.Supply = Supply;
            this.Yards = Yards;
        }
    }
}
