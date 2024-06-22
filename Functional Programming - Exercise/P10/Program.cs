namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();

            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] cmdArgs = command
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                string actions = cmdArgs[0];
                string filter = cmdArgs[1];
                string value = cmdArgs[2];

                if (actions == "Add filter")
                {
                    if (!filters.ContainsKey(filter + value))
                    {
                        filters.Add(filter + value, GetPredicate(filter, value));
                    }

                }
                else
                {
                    filters.Remove(filter + value);
                }

            }

            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }

            Console.WriteLine($"{String.Join(" ", people)}");
        }
        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    return p => p.StartsWith(value);
                case "Ends with":
                    return p => p.EndsWith(value);
                case "Length":
                    return p => p.Length == int.Parse(value);
                case "Contains":
                    return p => p.Contains(value);
                default:
                    return default;
            }
        }
    }
}
