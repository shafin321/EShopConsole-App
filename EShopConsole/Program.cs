using EShopConsole.Services;
using System;

namespace EShopConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            Product product = new Product();
            ProductService service = new ProductService();
            //service.Create(product);
            //service.Update(1, product);
            Console.WriteLine("List of products");

            // var products= service.GetAll();
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.Name} { item.Price}");
            //}

            ShowMenu();

            GetSwith();
            
           
           // service.GetProduct(1);
       
        }

        public static void GetSwith()
        {
            Cart cart = new Cart();
            Product product = new Product();
            ProductService service = new ProductService();

            Console.WriteLine("Select option");
            int option= int.Parse(Console.ReadLine());

            while(option != 5)
            {
                
                
                switch (option)
                {
                    case 1: cart.AddToCart(product); break;
                    case 2: cart.TotalCost(); break;
                    case 3: PrintProductList();break;
                    case 4: Clear(); break;
                    case 5: Console.WriteLine("Exit"); break;



                }
             
                Console.WriteLine();
                Console.WriteLine("Select option");
                option = int.Parse(Console.ReadLine());
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Slect 1-> Add Product");
            Console.WriteLine("Select 2-> Total Cost");
            Console.WriteLine("Select 3-> Show the Prouct List");
            Console.WriteLine("Select 4-> Clear");
            Console.WriteLine("Select 5-> Exixt");
        }

        public static void PrintProductList()
        {
            ProductService service = new ProductService();
            var products= service.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine($" {item.Id} {item.Name} {item.Price} ,{item.Category}");
            }

        }

        public static void Clear()
        {
            Console.Clear();
            ShowMenu();
        }


    }
}
