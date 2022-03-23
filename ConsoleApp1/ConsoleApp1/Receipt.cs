using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Receipt
    {
        public decimal subtotal { get; set; }
        public decimal salesTax { get; set; }
        public decimal total { get; set; }
        public decimal price { get; set; }
    }
}
