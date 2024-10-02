using System;
using _06.FoodShortage.Models.Iterfaces;
using FoodShortage.Models.Iterfaces;

namespace _06.FoodShortage.Models
{
    public class Rebel : INameable, IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Group { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}

