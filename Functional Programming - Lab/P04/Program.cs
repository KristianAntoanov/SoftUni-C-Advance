namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> parser = x => double.Parse(x);
            Func<double, double> vat = x => x * 1.2;

            List<double> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Select(vat)
                .ToList();

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item:f2}");
            }

        }
    }
}