namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using _05.BirthdayCelebrations.Models;
    using _05.BirthdayCelebrations.Models.Iterfaces;
    using BirthdayCelebrations.Models;
    using BirthdayCelebrations.Models.Iterfaces;

    public class Engine : IEngine
    {
        private List<IBirthable> birthables;

        public Engine()
        {
            birthables = new List<IBirthable>();
        }

        public void Run()
        {
            string input = string.Empty;
            IBirthable currObject;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdInfo[0] == "Citizen")
                {
                    currObject = new Citizen(cmdInfo[1], int.Parse(cmdInfo[2]), cmdInfo[3], cmdInfo[4]);
                    birthables.Add(currObject);
                }
                else if (cmdInfo[0] == "Pet")
                {
                    currObject = new Pet(cmdInfo[1], cmdInfo[2]);
                    birthables.Add(currObject);
                }
            }

            string year = Console.ReadLine();

            foreach (var item in birthables)
            {
                if (item.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(item.Birthdate);
                }
            }
        }
    }
}