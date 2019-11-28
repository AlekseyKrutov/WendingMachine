using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Inn { get; set; }
        public string Address { get; set; }
        public Company(string CompanyName, string Inn, string Address)
        {
            this.CompanyName = CompanyName;
            this.Inn = Inn;
            this.Address = Address;
        }
    }
}
