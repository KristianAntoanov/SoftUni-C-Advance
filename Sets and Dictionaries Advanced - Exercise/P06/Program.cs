namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Diagnostics.Metrics;
    using System.Drawing;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = cmdArgs[0];
                string[] inputPart2 = cmdArgs[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                for (int j = 0; j < inputPart2.Length; j++)
                {
                    string cllotesType = inputPart2[j];
                    if (!wardrobe[color].ContainsKey(cllotesType))
                    {
                        wardrobe[color][cllotesType] = 0;
                    }
                    wardrobe[color][cllotesType]++;
                }
            }
            string[] clotes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colorToFind = clotes[0];
            string clotesToFind = clotes[1];
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if (color.Key == colorToFind && item.Key == clotesToFind)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
