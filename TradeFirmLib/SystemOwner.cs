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
        //Must be Employee
        public string Director { get; set; }
        public SystemOwner(string Director, string CompanyName, string Inn, string Address)
            : base (CompanyName, Inn, Address)
        {
            this.Director = Director;
        }
    }
}
