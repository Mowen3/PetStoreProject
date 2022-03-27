using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Payment
    {
        public PaymentEnum PaymentType { get; set; }
        public int CardNumber { get; set; }
        public int Expiration { get; set; }
        public int CVV { get; set; }

        public int PayWithCash(int grandTotal)
        {
            Console.WriteLine("Please enter amount the amount you are paying with in cash:");
            var tenderedCash = Convert.ToInt32(Console.ReadLine());
            var change = grandTotal - tenderedCash;
            return change;
        }

        public void PayWithCard()
        {
            //do we need to parse as integers or do we just need to take the information as a string and display it later?
            Console.WriteLine("Please enter your credit card number");
            CardNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the card expiration date in the format: MMYYYY");
            Expiration = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the CVV code on the back of the card");
            CVV = int.Parse(Console.ReadLine());
        }

        public int PayWithCheck()
        {
            Console.WriteLine("Please enter your check number");
            var checkNumber = int.Parse(Console.ReadLine());
            return checkNumber;
        }

        public void PrintPaymentInfo()
        {
            Console.WriteLine("Payement Type:"+PaymentType);
        }
    }
}
