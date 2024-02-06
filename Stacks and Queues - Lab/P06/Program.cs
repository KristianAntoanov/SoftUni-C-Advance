namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "End")
            {
                if (commands == "Paid")
                {
                    foreach (var item in names)
                    {
                        Console.WriteLine(item);
                    }
                    names.Clear();
                    continue;
                }
                names.Enqueue(commands);
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
