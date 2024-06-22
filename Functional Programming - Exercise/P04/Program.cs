namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string evenOrOdd = Console.ReadLine();

            Predicate<int> checkIsEven = x => x % 2 == 0;
            List<int> numbers = new List<int>(Enumerable.Range(range[0], range[1] - range[0] + 1));

            print(checkIsEven, numbers, evenOrOdd);
        }
        static void print(Predicate<int> checkIsEven, List<int> numbers, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                Console.WriteLine(String.Join(" ", numbers.Where(x => checkIsEven(x))));
            }
            if (evenOrOdd == "odd")
            {
                Console.WriteLine(String.Join(" ", numbers.Where(x => !checkIsEven(x))));
            }
        }
    }
}
