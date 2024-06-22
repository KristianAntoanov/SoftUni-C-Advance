namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> result = new List<int>();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    result.Add(numbers[i]);
                }

                return result;
            };
            Action<List<int>> printer = x => Console.WriteLine(String.Join(" ", x));
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> divisible = x => x % n == 0;

            numbers = reverse(numbers);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (divisible(numbers[i]))
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            printer(numbers);
        }
    }
}
