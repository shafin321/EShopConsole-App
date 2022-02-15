using EShopConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShopConsole
{
   public class Cart
    {
        ProductService service = new ProductService();
        public List<Cart> CartItems { get; set; } = new List<Cart>();

        public  Product Product { get; set; }
        public int Quantity { get; set; }


        public void AddToCart(Product product)
        {
            Console.WriteLine("Choss product");
            product.Id = int.Parse(Console.ReadLine());
          var model =   service.GetAll().FirstOrDefault(p=>p.Id==product.Id);
            if (model.Stock >= 1)
            {
                Cart cart = new Cart
                {
                    Product = model,
                    Quantity = 1,

                };
                CartItems.Add(cart);
                model.Stock--;

                Console.WriteLine($"Product purched, {model.Name}, {model.Stock}" );
              
            }
            else
            {
                Console.WriteLine("Out of stock");
            }
           
        }
        public void TotalCost()
        {
            var total = CartItems.Select(p => p.Product.Price * p.Quantity).Sum();
            Console.WriteLine(total);
        }
    }
}
