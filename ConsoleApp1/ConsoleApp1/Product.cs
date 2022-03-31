using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product//should this be a private class?
    {
        //should any of these be private?
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryEnum Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        
    } 
}
