using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public class SystemOwner : Company
    {
        public Employee Director { get; set; }
        public SystemOwner() { }
        public SystemOwner(Employee Director, string CompanyName, string Inn, string Address)
            : base (CompanyName, Inn, Address)
        {
            this.Director = Director;
        }
    }
}
