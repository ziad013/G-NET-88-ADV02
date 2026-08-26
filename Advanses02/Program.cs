namespace Advanses02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
{
    new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
    new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
    new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
    new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
    new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
    new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
    new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
    new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
    new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
    new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
};

            Console.WriteLine("---Electronics---");
            List<Product> result01 = Product.SearchProducts(catalog, Product => Product.Category == "Electronics");
            foreach (Product item in result01)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("---Under $50---");
            List<Product> result02 = Product.SearchProducts(catalog, Product => Product.Price < 50);
            foreach (Product item in result02)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");


            Console.WriteLine("---In Stock---");
            List<Product> result03 = Product.SearchProducts(catalog, Product => Product.Stock > 0);
            foreach (Product item in result03)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");


            Console.WriteLine("--- Clothing Under $100 ---");
            List<Product> result04 = Product.SearchProducts(catalog, Product => Product.Price < 100 && Product.Category == "Clothing");
            foreach (Product item in result04)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("---Short Report---");
            Product.PrintReport(catalog, product => Console.WriteLine($"{product.Name} - ${product.Price}"));

            Console.WriteLine("\n\n");
            Console.WriteLine("---Detailed Report---");

            Product.PrintReport(catalog, product => Console.WriteLine($"[{product.Category}] {product.Name} | price: ${product.Price} | Stock: {product.Stock}"));

            Console.WriteLine("\n\n");
            Console.WriteLine("---Summary List---");
            List<string> res01 = Product.TransformProducts(catalog, product => $"{product.Name} (${product.Price})");

            foreach (string product in res01)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("---Price Labels---");
            List<string> res02 = Product.TransformProducts(catalog, product =>
            {
                if (product.Price > 100) return $"{product.Name}:  Expensive!";
                else return $"{product.Name}:  Affordable";

            });

            foreach (string product in res02)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("---Low-Stock Alert---");
            List<Product> res05 = Product.FindLowStock(catalog, product => product.Stock < 20);
            foreach (Product product in res05)
            {
                Console.WriteLine($" [LOW STOCK] {product.Name}: only {product.Stock} left!");
            }

        }
    }
}
