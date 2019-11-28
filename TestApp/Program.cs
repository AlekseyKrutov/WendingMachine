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
                ProductType pt1 = new ProductType(ProductTypes.Vegetables, 30);

                uc.ProductsType.Add(pt1);
                uc.SaveChanges();
                var types = uc.ProductsType;
                foreach (ProductType pt in types)
                {
                    Console.WriteLine($"{pt.TypeName}");
                }
            }
            Console.ReadLine();
        }
    }
}
