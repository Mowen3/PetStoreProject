using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Welcome to Pet Island, here's a list of our inventory. What would like to purchase?");

//Convert Json files to List



//Display inventory

var cart = new ShoppingCart();
var inventory = new Inventory();

while (true)
{
    inventory.DisplayInventory();

    //Add item to cart
    Console.WriteLine("type the id of the item that you want to purchase");

    var productId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter the quantity");
    var quantity = Convert.ToInt32(Console.ReadLine());

    var product = inventory.GetInventory().FirstOrDefault(x => x.Id == productId);
    Console.WriteLine($"Total Price: {product.Price * quantity}");

    cart.AddToCart(product,quantity);

    Console.WriteLine("Would you like to make another purchase? y/n");
    if (Console.ReadLine() == "n")
        break;
}

var receipt = new Receipt(cart);


Console.WriteLine($"Your Sub Total is:{receipt.subtotal}");
Console.WriteLine($"Your Tax Sales is:{receipt.salesTax}");
Console.WriteLine($"Your Grand Total is:{receipt.grandTotal}");

var payment = new Payment();
Console.WriteLine("Type the payment method that you want to use:\n1 for cash\n2 for credit\n3 for check");
payment.PaymentType = (PaymentEnum)Convert.ToInt32(Console.ReadLine());


if (payment.PaymentType == PaymentEnum.Cash)
    Console.WriteLine(payment.PayWithCash(receipt.GetGrandTotal()));

else if (payment.PaymentType == PaymentEnum.Credit)
    payment.PayWithCard();

else if (payment.PaymentType == PaymentEnum.Check)
    payment.PayWithCheck();

receipt.DisplayReceipt(payment);
