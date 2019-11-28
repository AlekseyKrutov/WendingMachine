using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public enum ProductTypes { Vegetables = 1}
    public class ProductType
    {
        public int Id { get; set; }
        public ProductTypes TypeName { get; set; }
        public int ShiftLifeDays { get; set; }
        public ProductType(ProductTypes TypeName, int ShiftLifeDays)
        {
            this.TypeName = TypeName;
            this.ShiftLifeDays = ShiftLifeDays;
        }
    }
}
