﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Shop.Product.Product;

namespace Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product(" ", 35, new DateTime(2003, 7, 10), "......"));
            ProductList.Add(new Product(" ", 18, new DateTime(2010, 2, 22), "......"));
            ProductList.Add(new Product(" ", 28, new DateTime(2012, 01, 01), "......"));
            ProductList.Add(new Product(" ", 35, new DateTime(2008, 01, 20), "......"));
            ProductList.Add(new Product(" ", 30, new DateTime(2011, 6, 3), "........"));
            ProductList.Add(new Product(" ", 35, new DateTime(2003, 7, 10), "......"));
            ProductList.Add(new Product(" ", 18, new DateTime(2010, 2, 22), "......"));
            ProductList.Add(new Product(" ", 28, new DateTime(2012, 01, 01), "......"));
            ProductList.Add(new Product(" ", 35, new DateTime(2008, 01, 20), "......"));
            ProductList.Add(new Product(" ", 30, new DateTime(2011, 6, 3), "........"));

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
