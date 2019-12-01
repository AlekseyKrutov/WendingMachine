using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFirmLib
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal TotalSum { get; set; }
        public DateTime PaymentDate { get; set; }
        public Employee Operator { get; set; }
        public Supply Supply { get; set; }
        public Payment() { }
        public Payment(Employee Operator, Supply Supply) 
        {
            this.Operator = Operator;
            this.Supply = Supply;
            this.PaymentDate = DateTime.Now;
            this.TotalSum = Supply.Products.Select(p => p.Cost).ToList().Sum();
        }
    }
}
