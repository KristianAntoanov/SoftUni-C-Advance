namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            HashSet<int> deviders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            int[] numbers = Enumerable.Range(1, n).ToArray();

            Action<string> printer = x => Console.WriteLine(x);
            foreach (var item in deviders)
            {
                predicates.Add(x => x % item == 0);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isDevisible = true;
                foreach (var item in predicates)
                {
                    if (!item(numbers[i]))
                    {
                        isDevisible = false;
                        break;
                    }
                }
                if (isDevisible)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
