using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradeFirmLib
{
    public enum Posts { Admin, Owner, Accepter}
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public Posts Post { get; set; }
        public bool ActiveFlag { get; set; }
        public Account Account { get; set; }
        public Employee(string Name, string Inn, Posts Post, Rights Right = Rights.Guest)
        {
            this.Name = Name;
            this.Inn = Inn;
            this.Post = Post;
            this.ActiveFlag = true;
            Account = new Account(this, Right);
        }
        public void Deactivate()
        {
            ActiveFlag = false;
            Account.ActiveFlag = false;
        }

    }
}
