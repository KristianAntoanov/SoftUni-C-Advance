using System;
namespace _05.Restaurant
{
	public abstract class Product
	{
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
		public decimal Price { get; set; }

	}
}

