namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using _06.FoodShortage.Models;
    using _06.FoodShortage.Models.Iterfaces;
    using FoodShortage;
    using FoodShortage.Models;
    using FoodShortage.Models.Iterfaces;

    public class Engine : IEngine
    {
        private List<IBuyer> buyers;

        public Engine()
        {
            buyers = new List<IBuyer>();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            IBuyer currObject;
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 3)
                {
                    currObject = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    buyers.Add(currObject);
                }
                else
                {
                    currObject = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    buyers.Add(currObject);
                }
            }

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "End")
            {
                foreach (var buyer in buyers)
                {
                    if (buyer.Name == commands)
                    {
                        buyer.BuyFood();
                    }
                }
            }
            Console.WriteLine(buyers.Sum(x => x.Food));
        }
    }
}