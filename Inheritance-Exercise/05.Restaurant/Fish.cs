using System;
namespace _05.Restaurant
{
    public class Fish : MainDish
    {
        private const double FishGrams = 22;
        public Fish(string name, decimal price) : base(name, price, FishGrams)
        {

        }
    }
}

