using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar" },
                new Category{CategoryId = 2, CategoryName = "Telefon" },
            };

            List<Product> products = new List<Product>()
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Lenovo", QuentityPerUnit = "16", UnitPrice = 30000, UnitsInStock = 20 },
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus", QuentityPerUnit = "32", UnitPrice = 40000, UnitsInStock = 10 },
                new Product{ProductId = 3, CategoryId = 1, ProductName = "Hp", QuentityPerUnit = "16", UnitPrice = 25000, UnitsInStock = 30 },
                new Product{ProductId = 4, CategoryId = 1, ProductName = "Msi", QuentityPerUnit = "32", UnitPrice = 55000, UnitsInStock = 40 },
                new Product{ProductId = 5, CategoryId = 1, ProductName = "Acer", QuentityPerUnit = "8", UnitPrice = 20000, UnitsInStock = 10 },
                new Product{ProductId = 6, CategoryId = 2, ProductName = "Apple", QuentityPerUnit = "4", UnitPrice = 40000, UnitsInStock = 80 },
                new Product{ProductId = 7, CategoryId = 2, ProductName = "Samsung", QuentityPerUnit = "4", UnitPrice = 10000, UnitsInStock = 70 },

            };

            Console.WriteLine("Algoritmik-----------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 30000 && product.UnitsInStock > 30)
                {
                    Console.WriteLine(product.ProductName);
                }
            }



            Console.WriteLine("Linq-----------------");

            var result = products.Where(p => p.UnitPrice > 30000 && p.UnitsInStock > 30);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        
        GetProducts(products);

        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 30000 && product.UnitsInStock > 30)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 30000 && p.UnitsInStock > 30).ToList();
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuentityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
