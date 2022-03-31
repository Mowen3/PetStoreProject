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
        public decimal grandTotal { get; set; }
        public Payment payment{ get; set; }
        private ShoppingCart cart { get; set; }

        //Handle exception here
        public Receipt(ShoppingCart cart)
        {
            this.cart = cart;
            subtotal = GetSubTotal();
            salesTax = GetSalesTaxes();
            grandTotal = GetGrandTotal();
        }


        //This method is to print the subtotal
        public decimal GetSubTotal()
        {
            return cart._ShoppingCart.Sum(x=>x.Price);
        }

        //This method is to print the sales tax
        public decimal GetSalesTaxes()
        {
            return GetSubTotal() * 0.06m;
        }

        //This method is to print the grand total
        public int GetGrandTotal()
        {
            return Convert.ToInt32(Math.Round(GetSubTotal() + GetSalesTaxes()));
        }


        //This method is to print all items in the cart, with their quantities and price respectively
        public void DisplayReceipt(Payment payment)
        {
            var groupedCart = cart._ShoppingCart.GroupBy(x => x.Id).Select(x => new
            {
                Name = x.First().Name,
                quantity = x.Count(),
                price = x.First().Price,
            }).ToList();

            for (var i = 0; i < groupedCart.Count(); i++)
            {
                //fix here to show price*quant
                Console.WriteLine($"{groupedCart[i].Name}, {groupedCart[i].quantity} , ${groupedCart[i].quantity * groupedCart[i].price}");
            }

            Console.WriteLine($"Sub Total: ${subtotal}");
            Console.WriteLine($"Sale Tax: ${salesTax}");
            Console.WriteLine($"Grand Total: ${grandTotal}");
            payment.PrintPaymentInfo();
        }


   
    }
}
