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
            Console.WriteLine("Please enter the amount in cash you are paying with:");
            var tenderedCash = Convert.ToInt32(Console.ReadLine());
            var change = tenderedCash - grandTotal;
            return change ;
        }

        //might be broken up
        public void PayWithCard()
        {
            //number should be string
            Console.WriteLine("Please enter your credit card number:");
            CardNumber = int.Parse(Console.ReadLine());

            //add private method for (helper method)
            //date time . parse
            //compare datetime now
            Console.WriteLine("Please enter the card expiration date in the format: MMYYYY");
            Expiration = int.Parse(Console.ReadLine());

            //add private method for (helper method)
            //should be a string
            //check num and right length
            Console.WriteLine("Please enter the CVV code on the back of your card");
            CVV = int.Parse(Console.ReadLine());
        }

        public void PayWithCheck()
        {
            //should be a string
            Console.WriteLine("Please enter your check number:");
            var checkNumber = int.Parse(Console.ReadLine());
        }

        public void PrintPaymentInfo()
        {
            Console.WriteLine("Payement Type:" + PaymentType);
        }
    }
}
