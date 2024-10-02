using System;
using _06.FoodShortage.Models.Iterfaces;
using FoodShortage.Models.Iterfaces;

namespace FoodShortage.Models
{
    public class Citizen : IBirthable, INameable, IIdentifiable, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}

