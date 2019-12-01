using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public enum ProductTypes { Vegetables = 1, Beverages, Chips, Chocolate, Juice}
    public class ProductType
    {
        public int Id { get; set; }
        public ProductTypes TypeName { get; set; }
        public int ShiftLifeDays { get; set; }
        public bool ActiveFlag { get; set; }
        public ProductType() { }
        public ProductType(ProductTypes TypeName, int ShiftLifeDays)
        {
            this.TypeName = TypeName;
            this.ShiftLifeDays = ShiftLifeDays;
            this.ActiveFlag = true;
        }
    }
}
