using ConsoleApp1;
using Xunit;

namespace PetStoreTests
{
    public class UnitTest1
    {
        [Fact]
        public void CartQuantityTest()
        {
            //arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product() { Name = "dog", Category = categoryEnum.Animal, Description = "Huge", Price = 5000 };
            //act
            cart.AddToCart(product, 3);
            //assert
            Assert.Equal(3, cart.GetNumItems());
            
        }

        [Fact]
        public void CartNameTest()
        {
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product() { Name = "dog", Category = categoryEnum.Animal, Description = "Huge", Price = 5000 };

            cart.AddToCart(product, 3);

            Assert.Equal("dog", cart.GetProducts()[0].Name);

            
        }

    }
}