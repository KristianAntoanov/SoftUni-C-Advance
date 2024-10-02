using System;
namespace PizzaCalories
{
	public class Topping
	{
        private const double BaseCaloriesPerGram = 2;
        private Dictionary<string, double> toppingTypesCalories;
        private double weight;
        private string type;

        public Topping(string type, double weight)
        {
            toppingTypesCalories = new Dictionary<string, double> { { "meat", 1.2 }, { "veggies", 0.8 }, { "cheese", 1.1 }, { "sauce", 0.9 } };
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            private set
            {
                if (!toppingTypesCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }
        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
        public double Calories
        {
            get
            {
                double typeModifier = toppingTypesCalories[type.ToLower()];

                return BaseCaloriesPerGram * Weight * typeModifier;
            }
        }
    }
}

