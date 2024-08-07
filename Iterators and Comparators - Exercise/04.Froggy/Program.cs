namespace Stack
{
    using System;
    using _04.Froggy;

    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Lake newLake = new Lake(stones);
            Console.WriteLine(String.Join(", ", newLake));
        }
    }
}