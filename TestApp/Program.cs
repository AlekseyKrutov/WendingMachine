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
                using (UserContext us = new UserContext())
                {
                }
            }
            Console.ReadLine();
        }
    }
}
