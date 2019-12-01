using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeFirmLib;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext uc = new UserContext())
            {
                var employee = uc.Employees.Single(e => e.Id == 4);
                var supplier = uc.Suppliers.Single(s => s.CompanyName == "ООО \"Творожок\"");

                var supply = uc.Supplies.Single(s => s.Id == 1);
                var p1 = uc.Products.Single(p => p.Id == 2);
                var p2 = uc.Products.Single(p => p.Id == 3);
                var p3 = uc.Products.Single(p => p.Id == 4);
                var yrd = uc.Yards.Select(y => y).Where(y => y.Id == 1).ToList();

                /*List<ProductQuantity> pr = new List<ProductQuantity>
                {
                    new ProductQuantity(p1, 400, 4000, supply, yrd),
                    new ProductQuantity(p2, 400, 5000, supply, yrd),
                    new ProductQuantity(p3, 500, 6000, supply, yrd)
                };
                foreach (ProductQuantity pq in pr)
                {
                    uc.ProductsQuantity.Add(p1);
                }*/

                var pp = new ProductQuantity { Id = 1, Product = p1, Quantity = 400, Cost = 4000, Supply = supply, Yards = yrd };
                uc.ProductsQuantity.Add(pp);
                uc.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
