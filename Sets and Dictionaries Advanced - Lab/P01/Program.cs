namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> sortedNumbers = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currNumber = numbers[i];
                if (!sortedNumbers.ContainsKey(currNumber))
                {
                    sortedNumbers[currNumber] = 0;
                }
                sortedNumbers[currNumber] += 1;
            }
            foreach (var key in sortedNumbers)
            {
                Console.WriteLine($"{key.Key} - {key.Value} times");
            }
        }
    }
}
