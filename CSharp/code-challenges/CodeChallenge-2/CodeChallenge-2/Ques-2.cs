using System;
using System.Linq;

namespace CodeChallenge_2
{
    class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    internal class Ques_2
    {
        static void Main(string[] args)
        {
            Products[] products = new Products[10];

            
            for (int i = 0; i < 10; i++)
            {
                products[i] = new Products();

                Console.WriteLine($"\nEnter details for Product {i + 1}:");

                Console.Write("Product ID: ");
                products[i].ProductId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                products[i].ProductName = Console.ReadLine();

                Console.Write("Price: ");
                products[i].Price = Convert.ToDouble(Console.ReadLine());
            }

            // Sorting
            var sortedProducts = products.OrderBy(p => p.Price);

            
            Console.WriteLine("\nProducts sorted by Price:");

            foreach (var p in sortedProducts)
            {
                Console.WriteLine($"ID: {p.ProductId}, Name: {p.ProductName}, Price: {p.Price}");
            }

            Console.ReadLine();
        }
    }
}