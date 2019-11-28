using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradeFirmLib
{
    public class MachineYard : Yard
    {
        public Machine Machine { get; set; }
        public MachineYard(List<Product> Products, Machine Machine) : 
            base(Machine.Model, Machine.Location, Products)
        {}
        public override void PopProduct(Product product)
        {
            base.PopProduct(product);
        }
        public override void PushProduct(Product product)
        {
            
            base.PushProduct(product);
        }
        public override void PopProducts(List<Product> products)
        {
            base.PopProducts(products);
        }
        public override void PushProducts(List<Product> products)
        {
            base.PushProducts(products);
        }
    }
}
