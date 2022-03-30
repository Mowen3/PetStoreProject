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
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public string CVV { get; set; }
        public string CheckNumber { get; set; }
        

        public int PayWithCash(int grandTotal)
        {
            Console.WriteLine("Please enter the amount in cash you are paying with:");
            var tenderedCash = Convert.ToInt32(Console.ReadLine());
            var change = grandTotal - tenderedCash;
            return change ;
        }

        public void PayWithCard()
        {
            Console.WriteLine("Please enter your credit card number:");
            CardNumber = Console.ReadLine();

            Console.WriteLine("Please enter the card expiration date in the format: MM/YYYY");
            Expiration = Console.ReadLine();  
            bool isCardExpired = CheckExpiration(Expiration);
            while (!isCardExpired)
            {
                Console.WriteLine("Card is expired, Please try again");
                Expiration = Console.ReadLine();
                isCardExpired = CheckExpiration(Expiration);
            }

            Console.WriteLine("Please enter the CVV code on the back of your card");
            CVV = Console.ReadLine();
        }

        public void PayWithCheck()
        {
            Console.WriteLine("Please enter your check number:");
            CheckNumber = Console.ReadLine();
        }

        public void PrintPaymentInfo()
        {
            
            if(PaymentType == PaymentEnum.Credit)
            {
                Console.WriteLine("Payement Type:" + PaymentType);
                Console.WriteLine($"Card number: {CardNumber}, Expiration: {Expiration}, CVV Code: {CVV}");
            }
            else if (PaymentType == PaymentEnum.Check)
            {
                Console.WriteLine("Payement Type:" + PaymentType);
                Console.WriteLine($"Check number: {CheckNumber}");
            }
            else
            {
                Console.WriteLine("Payement Type:" + PaymentType);
            }
        }

        private bool CheckExpiration(string date)
        {
            DateTime newExpiration = DateTime.ParseExact(date, "mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            if (newExpiration < DateTime.Today)
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }
    }
}
