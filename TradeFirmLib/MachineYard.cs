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
        public MachineYard() { }
        public MachineYard( Machine Machine) : 
            base(Machine.Model, Machine.Location)
        {
            this.Machine = Machine;
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
