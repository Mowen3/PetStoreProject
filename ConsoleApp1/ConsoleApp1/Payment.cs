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
            var change = tenderedCash - grandTotal;
            return change ;
        }

        
        public void PayWithCard()
        {

            InputCardNumber();
            CheckExpiration();          
            CheckCvv();

            
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

        private void CheckExpiration()
        {
            
            bool isNotExpired = false;
            while (!isNotExpired)
            {
                Console.WriteLine("Please enter an expiration date in: mm/yyyy");
                Expiration = Console.ReadLine();
                DateTime newExpiration;
                if (string.IsNullOrEmpty(Expiration))
                {
                    Console.WriteLine("Please put in a expiration date");
                    continue;
                }
                else if(Expiration.Length != 7)
                {
                    Console.WriteLine("The expiration date should be in format mm/yyyy");
                    continue;
                }
                else
                    {
                       newExpiration = DateTime.ParseExact(Expiration, "mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                        if(newExpiration < DateTime.Today)
                        {
                            Console.WriteLine("This card is expired. Please try again");
                            continue;
                        }
                        else
                        {
                        Console.WriteLine("Your expiration date has been accepted");
                            isNotExpired = true;
                        }
                    }
                 
                }
            }
                
        

        private void InputCardNumber()
        {
            bool isValid = false;
            while(!isValid)
            {
                Console.WriteLine("Please enter your credit card number:");
                CardNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(CardNumber))
                {
                    Console.WriteLine("Please put in a valid card number");
                    continue;
                }
                else if(CardNumber.Length != 16)
                {
                    Console.WriteLine("A credit card should be 16 digits long. Please try again");
                    continue;
                }
                else if (!CardNumber.All(char.IsDigit))
                {
                    Console.WriteLine("Card numbers should only be numbers");
                    continue;
                }
                else
                {
                    Console.WriteLine("Your card number has been accepted");
                    isValid = true;
                }
            }
       
        }

        private void CheckCvv()
        {
            bool isValid = false;
            while (!isValid)
            {


                Console.WriteLine("Please enter the CVV code on the back of your card");
                CVV = Console.ReadLine();

                if (string.IsNullOrEmpty(CVV))
                {
                    Console.WriteLine("please enter a valid CVV");
                    continue;
                }
                else if (CVV.Length != 3)
                {
                    Console.WriteLine("CVV numbers should be 3 digits");
                    continue;
                }
                else if (!CVV.All(char.IsDigit))
                {
                    Console.WriteLine("CVV numbers should only be digits");
                    continue;
                }
                else
                {
                    Console.WriteLine("CVV has been accepted");
                    isValid = true;
                }
            }
        }

    }

}
