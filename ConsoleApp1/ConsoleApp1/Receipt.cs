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
        public decimal productTotal { get; set; }
        private ShoppingCart purchased { get; set; }

        public Receipt(decimal subtotal, decimal salesTax, decimal total, decimal price)
        {
            this.subtotal = subtotal;
            this.salesTax = salesTax;
            this.total = total;
            this.price = price;
        }

        public decimal PrintToConsole()
        {
            foreach (var product in purchased.GetProducts())
            {
                int quantity = purchased.GetProducts().Where(x => x.Name == product.Name).Count();
                Console.WriteLine($"{product.Name} ({quantity}) - ${product.Price}");
                decimal productTotal = (product.Price * quantity);
            }

            return productTotal;
        }

        decimal subTotal = 0.00m;

        public void Total()
        {
            foreach (var product in purchased.GetProducts())
            {
                subTotal += productTotal;
                Console.WriteLine($"Subtotal: {subTotal}");

            }

        }
    }
}
