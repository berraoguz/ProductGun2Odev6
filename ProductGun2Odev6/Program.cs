using System;

namespace ProductGun2Odev6
{
    class Program
    {

     class Product
        {
            public string ProductName { get; set; }
            public string ProductSaler { get; set; }
            public int UnitPrice { get; set; }
            public int CategoryID { get; set; }
            public int Stock { get; set; }
        }

        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Sunglasses";
            product1.ProductSaler = "Prada";
            product1.UnitPrice = 2080;
            product1.CategoryID = 1;
            product1.Stock = 300;

            Product product2 = new Product();
            product2.ProductName = "Perfume";
            product2.ProductSaler = "Channel";
            product2.UnitPrice = 1700;
            product2.CategoryID = 2;
            product2.Stock = 425;

            Product product3 = new Product();
            product3.ProductName = "Bag";
            product3.ProductSaler = "Louis Vuitton";
            product3.UnitPrice = 10000;
            product3.CategoryID = 3;
            product3.Stock = 210;

            Product[] products = new Product[] { product1, product2, product3 }; 

            Console.WriteLine("----FOREACH----");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductSaler + " : " + product.UnitPrice + " : " + product.CategoryID + " : " + product.Stock);
            }

            Console.WriteLine("----FOR----");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " : " + products[i].ProductSaler + " : " + products[i].UnitPrice + " : " + products[i].CategoryID + " : " + products[i].Stock);                
            }

            Console.WriteLine("----WHILE----");
            int j = 0;
            while (j<products.Length)
            {
                Console.WriteLine(products[j].ProductName + " : " + products[j].ProductSaler + " : " + products[j].UnitPrice + " : " + products[j].CategoryID + " : " + products[j].Stock);
                j++;
            }


        }
    }
}
