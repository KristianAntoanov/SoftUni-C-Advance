namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split();
                string currContinent = cmdArgs[0];
                string currCountrie = cmdArgs[1];
                string currCitie = cmdArgs[2];
                if (!continents.ContainsKey(currContinent))
                {
                    continents[currContinent] = new Dictionary<string, List<string>>();
                }
                if (!continents[currContinent].ContainsKey(currCountrie))
                {
                    continents[currContinent][currCountrie] = new List<string>();
                }
                continents[currContinent][currCountrie].Add(currCitie);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var countrie in continent.Value)
                {
                    Console.Write($"    {countrie.Key} -> ");
                    Console.Write(String.Join(", ", countrie.Value));
                    Console.WriteLine();
                }

            }
        }
    }
}
