using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public class Contract
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime ConfirmDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool ActiveFlag { get; set; }
        public Contract(Supplier Supplier, DateTime? ConfirmDate = null, DateTime? FinishDate = null)
        {
            this.Supplier = Supplier;
            this.ConfirmDate = (ConfirmDate == null) ? DateTime.Now : (DateTime) ConfirmDate;
            this.FinishDate = (FinishDate == null) ? DateTime.Now.AddDays(1): (DateTime)FinishDate;
            this.ActiveFlag = true;
        }
        public void CancelContract()
        {
            ActiveFlag = false;
        }
    }
}
