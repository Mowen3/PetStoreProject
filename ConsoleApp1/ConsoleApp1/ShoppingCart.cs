using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ShoppingCart
    {
        //private List<Product> _productList { get; set; }
        
        
        public List <Product> _productList = new List<Product>();

        

        public void DisplayCart()
        {
            for (var i = 0; i < _productList.Count(); i++)
            {

                Console.WriteLine($"[{i + 1}]" + _productList[i].ToString());
            }
        }


        public void AddToCart(int addThis)
        {
            //_productList.Add(stockList[addThis]);
            //Console.WriteLine("How many would you like to buy?");
            //int quantity = int.Parse(Console.ReadLine());
            //Console.WriteLine($"You have added {quantity} of {stockList[addThis]}");
        }


        public void RemoveFromCart(int input, int quantity)
        {
            _productList.Remove(_productList[input]);
        }

    }
}
