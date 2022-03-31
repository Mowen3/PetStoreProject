using ConsoleApp1;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Welcome to Pet Island, here's a list of our inventory. What would like to purchase?");

var inventory = new Inventory();

var cart = new ShoppingCart();



while (true)
{
    Console.WriteLine();
    inventory.DisplayInventory();

    Console.WriteLine("Please type the number of the item that you want to purchase:");

    var item = Convert.ToInt32(Console.ReadLine());

    try
    {
        if (item > 26);

    }
    catch
    {
        Console.WriteLine("Please make sure to pick a number between 1 and 25");
    }


    Console.WriteLine($"How many of that item would like to buy?");
    var quantity = Convert.ToInt32(Console.ReadLine());

    var product = inventory.GetInventory().FirstOrDefault(x => x.Id == item);
    Console.WriteLine($"Your total Price is: ${product.Price * quantity}");

    cart.AddToCart(product,quantity);

    Console.WriteLine("Would you like to make another purchase? y/n");
    if (Console.ReadLine() == "n")
        break;
}


var receipt = new Receipt(cart);


Console.WriteLine($"Your Subtotal is: ${receipt.subtotal}");
Console.WriteLine($"Your Sales Tax is: ${receipt.salesTax}");
Console.WriteLine($"Your Grand Total is: ${receipt.grandTotal}");

var payment = new Payment();
Console.WriteLine("Type the payment method that you want to use:\n1 for cash\n2 for credit\n3 for check");
payment.PaymentType = (PaymentEnum)Convert.ToInt32(Console.ReadLine());


if (payment.PaymentType == PaymentEnum.Cash)
    Console.WriteLine($"Your change is ${payment.PayWithCash(receipt.GetGrandTotal())}");

else if (payment.PaymentType == PaymentEnum.Credit)
    payment.PayWithCard();

else if (payment.PaymentType == PaymentEnum.Check)
    payment.PayWithCheck();

receipt.DisplayReceipt(payment);

Console.WriteLine();
Console.WriteLine("Thank you and have a great day");





