using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ShoppingCart
    {

        private List <Product> _ShoppingCart = new List<Product>();            


        public void DisplayCart()
        {
            for (var i = 0; i < _ShoppingCart.Count(); i++)
            {

                Console.WriteLine($"[{i + 1}]" + _ShoppingCart[i].ToString());
            }
        }


        public void AddToCart(int addThis)
        {
            //_ShoppingCart.Add(stockList[addThis]);
            //Console.WriteLine("How many would you like to buy?");
            //int quantity = int.Parse(Console.ReadLine());
            //Console.WriteLine($"You have added {quantity} of {stockList[addThis]}");
        }


        public void RemoveFromCart(int input, int quantity)
        {
            _ShoppingCart.Remove(_ShoppingCart[input]);
        }

    }
}
