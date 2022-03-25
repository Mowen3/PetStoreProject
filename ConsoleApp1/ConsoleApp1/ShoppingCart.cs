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

        public List<Product> GetProducts()
        {
            return _ShoppingCart;
        }
    }
}
