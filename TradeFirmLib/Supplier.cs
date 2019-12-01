using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public class Supplier : Company
    {
        public string Director { get; set; }
        // public Contract Contract { get; set; }
        public Supplier() { }
        public Supplier(string Director, string CompanyName, string Inn, string Address)
            : base (CompanyName, Inn, Address)
        {
            this.Director = Director;
        }
        public void MakeContract()
        {

        }
    }
}
