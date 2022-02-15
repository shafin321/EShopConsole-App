using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShopConsole.Services
{
  public  class ProductService
    {
        Product product = new Product();
        List<Product> products = new List<Product>();
        public ProductService()
        {
            products.Add(new Product { Id = 1, Category = ProductCategory.ConsoleGame, Name = "Ps4", Price = 300, Stock = 3 });
            products.Add(new Product { Id = 2, Category = ProductCategory.Laptop, Name = "Asus", Price = 800, Stock = 2 });
            products.Add(new Product { Id = 3, Category = ProductCategory.Mobile, Name = "S9", Price = 200, Stock = 2 });
            products.Add(new Product { Id = 4, Category = ProductCategory.Mobile, Name = "S10", Price = 300, Stock = 2 });
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public void GetProduct(int id)
        {
            var model= products.FirstOrDefault(p => p.Id == id);
            Console.WriteLine(model.Name);
        }

        public string   Search()
        {
            //foreach (var item in products)
            //{
            //    if (item.Name == search)
            //    {
            //        return item.Name;
            //    }
            //}
            Console.WriteLine("Enter a product for search");
            string search = Console.ReadLine();
            var product = products.Where(p => p.Name.Contains(search)).FirstOrDefault();
            return product.Name;
          
            

            
            
        }

        public void Create(Product product)
        {
            Console.WriteLine("Enter a product name");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter a price ");
            product.Price = decimal.Parse(Console.ReadLine());
            products.Add(product);
        }

        public void Update(int id, Product product)
        {
            var model = products.FirstOrDefault(p => p.Id == id);
            Console.WriteLine("Write change product ");
            product.Name = Console.ReadLine();
            model.Name = product.Name;
            
        }
    }
}
