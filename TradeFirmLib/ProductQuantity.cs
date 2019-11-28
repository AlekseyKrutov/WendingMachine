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
        [Key]
        [ForeignKey("Product")]
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public IList<Yard> Yards{ get; set; }
        public ProductQuantity(Product Product, int Quantity, List<Yard> Yards)
        {
            this.Product = Product;
            this.Quantity = Quantity;
            this.Yards = Yards;
        }
    }
}
