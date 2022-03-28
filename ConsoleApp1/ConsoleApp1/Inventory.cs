using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inventory
    {
        private List<Product> _Inventory = new List<Product>();

        public Inventory()
        {
            var jsonFile = File.ReadAllText("json1.json");
            _Inventory = JsonConvert.DeserializeObject<List<Product>>(jsonFile);
        }

        public void DisplayInventory()
        {
            for (var i = 0; i < _Inventory.Count(); i++)
            {
                Console.WriteLine($"{_Inventory[i].Id} {_Inventory[i].Name} , {_Inventory[i].Description} , ${_Inventory[i].Price}");
            }
            Console.WriteLine();
        }

        public List<Product> GetInventory()
        {
            return _Inventory;
        }

    }
}
