using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradeFirmLib
{
    public class Machine
    {
        public int Id { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }
        public string Firm { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Location { get; set; }
        public bool ActiveFlag { get; set; }
        public DateTime LastRepairDate { get; set; }
        public DateTime LastActivityDate { get; set; }
        public Employee LastOperator { get; set; }
        public float CashSum { get; set; }
        public List<float> CashInMachine { get; }
        public List<float> PaymentBuffer { get; }
        public Machine(int Columns, int Rows, string Firm, string Model,
                        string sNumber, string Location, List<float> CashInMachine)
        {
            this.Columns = Columns;
            this.Rows = Rows;
            this.Firm = Firm;
            this.Model = Model;
            this.SerialNumber = sNumber;
            this.Location = Location;
            this.CashInMachine = CashInMachine;
        }
        public void ChangeMachine(Machine machine) { }
        public void CancelBuying() { }
        public bool BuyProduct(Product product) => true;
        public List<float> GiveChange() => new List<float>();
    }
}
