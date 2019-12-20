using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public struct MachineProduct
    {
        public string NameProd { get; set; }
        public decimal Cost { get; set; }
    }
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
        public List<MachineProduct> Products { get; set; } = new List<MachineProduct>();
        public DateTime LastRepairDate { get; set; }
        public DateTime LastActivityDate { get; set; }
        public Employee LastOperator { get; set; }
        public double CashSum { get; set; }
        public List<double> PaymentBuffer { get; set; } = new List<double>();
        public Machine() { }
        public Machine(int Columns, int Rows, string Firm, string Model,
                        string sNumber, string Location) : this()
        {
            this.Columns = Columns;
            this.Rows = Rows;
            this.Firm = Firm;
            this.Model = Model;
            this.SerialNumber = sNumber;
            this.Location = Location;
            this.ActiveFlag = true;
            this.LastRepairDate = DateTime.Now;
            this.LastActivityDate = DateTime.Now;
        }
        public void CancelBuying()
        {
            
        }
        public bool FillProducts(List<ProductYard> products)
        {
            if (products.Count > Rows * Columns)
                return false;
            for (int i = 0; i < products.Count; i++)
            {
                ProductQuantity pq = products[i].Supply.Products
                    .Single(p => p.Product == products[i].Product);
                Products.Add(new MachineProduct { NameProd = pq.Product.ProductName,
                Cost = pq.Cost});
            }
            return true;
        }
        public void AddMoney(double money)
        {
            PaymentBuffer.Add(money);
        }
        public bool BuyProduct(int index) 
        {
            double Discharge = 0;
            Discharge = PaymentBuffer.Sum() - (double)Products[index].Cost;
            if (CashSum - Discharge < 0)
            {
                Discharge = 0;
                return false;
            }
            CashSum += PaymentBuffer.Sum();
            Products.RemoveAt(index);
            CashSum -= Discharge;
            return true;
        }
    }
}
