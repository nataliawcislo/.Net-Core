using System;
using System.Collections.Generic;

namespace Shop.Product
{
    public class Product 
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime Description { get => Description; set => Description = value; }
        public string DataAdd { get; set; }
       
        public Product(string name, float price,  DateTime description, string dataAdd)
        {
            Name = name;
            Price = price;
            Description = description;
            DataAdd = dataAdd;
        }

    }
}
