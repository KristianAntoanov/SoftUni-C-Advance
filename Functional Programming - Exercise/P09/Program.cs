namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string actions = cmdArgs[0];
                string filter = cmdArgs[1];
                string value = cmdArgs[2];

                if (actions == "Remove")
                {
                    people.RemoveAll(GetPredicate(filter, value));
                }
                else
                {
                    List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));

                    foreach (var person in peopleToDouble)
                    {
                        int index = people.FindIndex(p => p == person);
                        people.Insert(index, person);
                    }
                }

            }
            if (people.Any())
            {
                Console.WriteLine($"{String.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return p => p.StartsWith(value);
                case "EndsWith":
                    return p => p.EndsWith(value);
                case "Length":
                    return p => p.Length == int.Parse(value);
                default:
                    return default;
            }
        }
    }
}
