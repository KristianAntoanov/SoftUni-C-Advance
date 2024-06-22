namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<string> printer = x => Console.WriteLine($"Sir {x}");

            names.ForEach(x => printer(x));
        }
    }
}
