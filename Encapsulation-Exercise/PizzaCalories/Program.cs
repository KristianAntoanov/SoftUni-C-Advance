namespace PizzaCalories
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] pizzaTokens = Console.ReadLine().Split();
                string[] doughTokens = Console.ReadLine().Split();

                Dough dough = new Dough(doughTokens[1], doughTokens[2], double.Parse(doughTokens[3]));
                Pizza pizza = new Pizza(pizzaTokens[1], dough);

                string toppings = string.Empty;
                while ((toppings = Console.ReadLine()) != "END")
                {
                    string[] toppingsTokens = toppings.Split();
                    Topping topping = new Topping(toppingsTokens[1], double.Parse(toppingsTokens[2]));
                    pizza.AddTopping(topping);
                }
                Console.WriteLine(pizza.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}