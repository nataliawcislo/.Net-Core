using System;
namespace Shop.Product
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string DataAdd { get; set; }
        public DateTime Description { get => Description; set => Description = value; 

        public Product(string name, float price, string dataAdd, DateTime description)
        {
            this.Name = name;
            this.Price = price;
            this.DataAdd = dataAdd;
            this.Description = description;
        }
    }
}
