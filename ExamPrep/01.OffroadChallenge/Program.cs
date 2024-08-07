namespace OffroadChallenge
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> initialFuel = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> consumptionIndexes = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> quantitiesNeeded = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            List<string> reachedAltitudes = new();
            for (int i = 1; i <= 4; i++)
            {
                int currFuel = initialFuel.Peek();
                int currIndex = consumptionIndexes.Peek();
                int currQuantity = quantitiesNeeded.Peek();

                if (currFuel - currIndex >= currQuantity)
                {
                    reachedAltitudes.Add($"Altitude {i}");
                    Console.WriteLine($"John has reached: Altitude {i}");
                    initialFuel.Pop();
                    consumptionIndexes.Dequeue();
                    quantitiesNeeded.Dequeue();
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {i}");
                    break;
                }
            }
            if (reachedAltitudes.Count == 4)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
            if (initialFuel.Any() && reachedAltitudes.Count > 0)
            {
                Console.WriteLine($"John failed to reach the top.");
                Console.Write($"Reached altitudes: {String.Join(", ", reachedAltitudes)}");
            }
            if (initialFuel.Any() && reachedAltitudes.Count == 0)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }
        }
    }
}