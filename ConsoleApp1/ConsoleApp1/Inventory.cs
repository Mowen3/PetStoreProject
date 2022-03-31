//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Spectre.Console;

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


            
            var table = new Spectre.Console.Table();
            table.Border = TableBorder.DoubleEdge;

            // Add some columns
            table.AddColumn("[bold darkorange3_1]Item ID #[/]");
            table.AddColumn(new TableColumn("[bold darkorange3_1]Item Name[/]").Centered());
            table.AddColumn(new TableColumn("[bold darkorange3_1]Item Category[/]").Centered());
            table.AddColumn(new TableColumn("[bold darkorange3_1]Item Description:open_book:[/]").Centered());
            table.AddColumn(new TableColumn("[bold darkorange3_1]Price($):money_bag:[/]").Centered());

            // Add some rows
            for (var i = 0; i < _Inventory.Count(); i++)
            {
                table.AddRow(_Inventory[i].Id.ToString(), _Inventory[i].Name.ToString(), _Inventory[i].Category.ToString(), _Inventory[i].Description.ToString(), _Inventory[i].Price.ToString());
                table.AddRow("");
            }


            // Render the table to the console
            AnsiConsole.Write(table);

        }

        public List<Product> GetInventory()
        {
            return _Inventory;
        }

    }
}

//Library to use: string.format
