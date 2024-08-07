namespace WormsHoles
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> worms = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> holes = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int matches = 0;
            bool allFit = true;

            while (worms.Any() && holes.Any())
            {
                if (worms.Peek() < 1)
                {
                    worms.Pop();
                    continue;
                }
                if (worms.Peek() == holes.Peek())
                {
                    matches++;
                    worms.Pop();
                    holes.Dequeue();
                }
                else
                {
                    int currWorm = worms.Pop();
                    currWorm -= 3;
                    worms.Push(currWorm);
                    holes.Dequeue();
                    allFit = false;
                }
            }
            if (matches > 0)
            {
                Console.WriteLine($"Matches: {matches}");
            }
            else
            {
                Console.WriteLine("There are no matches.");
            }
            if (!worms.Any() && allFit)
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }
            else if (!worms.Any() && !allFit)
            {
                Console.WriteLine("Worms left: none");
            }
            if (worms.Any())
            {
                Console.WriteLine($"Worms left: {String.Join(", ", worms)}");
            }
            if (!holes.Any())
            {
                Console.WriteLine("Holes left: none");
            }
            else
            {
                Console.WriteLine($"Holes left: {String.Join(", ", holes)}");
            }
        }
    }
} 