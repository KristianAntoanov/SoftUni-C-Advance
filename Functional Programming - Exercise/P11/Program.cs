namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> checkEqualOrLargerNameSum = (name, sum) => name.Sum(ch => ch) >= sum;

            Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match) => names.FirstOrDefault(name => match(name, sum));

            int sum = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string foundName = getFirstName(names, sum, checkEqualOrLargerNameSum);

            Console.WriteLine(foundName);
        }
    }
}
