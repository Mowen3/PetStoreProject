using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Payment
    {

        public decimal PayWithCash(decimal grandTotal)
        {
            Console.WriteLine("Please enter amount the amount you are paying with in cash:");
            var tenderedCash = decimal.Parse(Console.ReadLine());
            var change = grandTotal - tenderedCash;
            return change;
        }

        public void PayWithCard()
        {
            //do we need to parse as integers or do we just need to take the information as a string and display it later?

            Console.WriteLine("Please enter your credit card number");
            var cardNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the card expiration date");
            var expiration = Console.ReadLine();
            Console.WriteLine("Please enter the CVV code on the back of the card");
            var cvv = int.Parse(Console.ReadLine());

        }

        public int PayWithCheck()
        {
            Console.WriteLine("Please enter your check number");
            var checkNumber = int.Parse(Console.ReadLine());
            return checkNumber;
        }

        public void PrintPaymentInfo()
        {
            throw new NotImplementedException();
        }
    }
}
