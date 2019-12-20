using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFirmLib
{
    public class ProductYard
    {
        public int Id { get; set; }
        public Supply Supply { get; set; }
        public Product Product { get; set; }
        public Yard Yard { get; set; }
        public int Quantity { get; set; }
        public ProductYard() { }
    }
}
