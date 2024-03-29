﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TradeFirmLib;

namespace TestApp
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=DbConnection") { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineYard> MachineYards { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductQuantity> ProductsQuantity { get; set; }
        public DbSet<ProductType> ProductsType { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SystemOwner> SystemOwners { get; set; }
        public DbSet<Yard> Yards { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductYard> ProductYards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

}
