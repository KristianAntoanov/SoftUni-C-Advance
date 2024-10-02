using System;
namespace _05.Restaurant
{
    public abstract class Food : Product
    {
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }
        public double Grams { get; set; }
    }
}

