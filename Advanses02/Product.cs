using System;
using System.Collections.Generic;
using System.Text;

namespace Advanses02
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List<Product> SearchProducts(List<Product> products, Predicate<Product> filter)
        {
            List<Product> result = products.FindAll(filter);
            return result;
        }

        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (Product product in products) 
            {
                action(product);
            }
        }

        public static List<string> TransformProducts(List<Product> products,Func<Product, string> transform)
        {
            List<string> result = new List<string>();

            foreach (Product product in products)
            {
                result.Add(transform(product));
            }
 
            return result;
        }

        public static List<Product> FindLowStock(List<Product> products,Predicate<Product> Alert)
        {
            List<Product> result = products.FindAll(Alert);
            return result;
        }
        public override string ToString()
        {
            return $"{Name} - ${Price} (Stock: {Stock})";
        }

    }
}
