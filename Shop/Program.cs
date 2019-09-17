using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product.Product> ProductList = new List<Product.Product>();
            ProductList.Add(new Product.Product(" ", 35, new DateTime(2003, 7, 10), "......"));
            ProductList.Add(new Product.Product(" ", 18, new DateTime(2010, 2, 22), "......"));
            ProductList.Add(new Product.Product(" ", 28, new DateTime(2012, 01, 01), "......"));
            ProductList.Add(new Product.Product(" ", 35, new DateTime(2008, 01, 20), "......"));
            ProductList.Add(new Product.Product(" ", 30, new DateTime(2011, 6, 3), "........"));
            ProductList.Add(new Product.Product(" ", 35, new DateTime(2003, 7, 10), "......"));
            ProductList.Add(new Product.Product(" ", 18, new DateTime(2010, 2, 22), "......"));
            ProductList.Add(new Product.Product(" ", 28, new DateTime(2012, 01, 01), "......"));
            ProductList.Add(new Product.Product(" ", 35, new DateTime(2008, 01, 20), "......"));
            ProductList.Add(new Product.Product(" ", 30, new DateTime(2011, 6, 3), "........"));

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
