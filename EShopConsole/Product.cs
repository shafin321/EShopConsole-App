using System;
using System.Collections.Generic;
using System.Text;

namespace EShopConsole
{
 public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }
        
    }
}
