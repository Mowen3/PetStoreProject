using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ShoppingCart
    {

        public List <Product> _ShoppingCart = new List<Product>();

        
        public void DisplayCart()
        {
            for (var i = 0; i < _ShoppingCart.Count(); i++)
            {
                Console.WriteLine($"{_ShoppingCart[i].Id} , {_ShoppingCart[i].Name} , {_ShoppingCart[i].Price} , {_ShoppingCart[i].Description}");
            }
            Console.WriteLine();
        }


        public void AddToCart(Product product, int quantity)
        {                  
            for (var i = 0; i < quantity; i++)
            {
                _ShoppingCart.Add(product);
            }            
        }


        public void RemoveFromCart(int input, int quantity)
        {
            _ShoppingCart.Remove(_ShoppingCart[input]);
        }


        public int GetNumItems()
        {
            return _ShoppingCart.Count;
        }

        //public List<Product> GetProducts()
        //{
        //    return _ShoppingCart;
        //}
    }
}
