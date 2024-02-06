namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] cmdArgs = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int cmdType = cmdArgs[0];
                if (cmdType == 1)
                {
                    int cmdValue = cmdArgs[1];
                    numbers.Push(cmdValue);
                }
                else if (cmdType == 2)
                {
                    numbers.Pop();
                }
                else if (cmdType == 3)
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (cmdType == 4)
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
