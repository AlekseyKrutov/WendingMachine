﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public class Supply
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime SupplyDate { get; set; }
        public bool ActiveFlag { get; set; }
        public Employee StockMan { get; set; }
        public IList<ProductQuantity> Products { get; set; }
        public Supply() { }
        public Supply(Supplier Supplier, Employee StockMan, DateTime? SupplyDate = null)
        {
            this.Supplier = Supplier;
            this.StockMan = StockMan;
            this.ActiveFlag = true;
            this.SupplyDate = (SupplyDate == null) ? DateTime.Now : (DateTime)SupplyDate;
        }
        public Supply(Supplier Supplier, Employee StockMan, 
            List<ProductQuantity> Products, DateTime? SupplyDate) : this(Supplier, StockMan, SupplyDate)
        {
            this.Products = Products;
        }
        public void CloseSupply(Yard yard) 
        {
            this.ActiveFlag = false;
            foreach (ProductQuantity pq in Products)
            {
                yard.Products.Add(pq);
                pq.Supply = this;
            }
        }
        public void CancelSupply()
        {
            if (!ActiveFlag)
                return;
            ActiveFlag = false;
            Products.Clear();
        }
        public Payment PayOffSupply(Employee Operator)
        {
            return new Payment(Operator, this);
        }
        public void SupplyProductsInMachine() { }
    }
}
