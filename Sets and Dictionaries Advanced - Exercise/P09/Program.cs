namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> examResult = new SortedDictionary<string, int>();
            SortedDictionary<string, int> languageSubmitions = new SortedDictionary<string, int>();

            string inputs = string.Empty;
            while ((inputs = Console.ReadLine()) != "exam finished")
            {
                string[] cmdArgs = inputs
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                if (cmdArgs[1] == "banned")
                {
                    if (examResult.ContainsKey(cmdArgs[0]))
                    {
                        examResult.Remove(cmdArgs[0]);
                    }
                    continue;
                }
                string language = cmdArgs[1];
                int points = int.Parse(cmdArgs[2]);
                if (!examResult.ContainsKey(name))
                {
                    examResult[name] = 0;
                }
                if (examResult[name] < points)
                {
                    examResult[name] = points;
                }
                if (!languageSubmitions.ContainsKey(language))
                {
                    languageSubmitions[language] = 0;
                }
                languageSubmitions[language]++;
            }
            Console.WriteLine("Results:");
            foreach (var name in examResult.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{name.Key} | {name.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageSubmitions.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
