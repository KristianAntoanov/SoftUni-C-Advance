namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cmd = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int[] elementsToAppend = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>(elementsToAppend);
            
            for (int i = 0; i < cmd[1]; i++)
            {
                numbers.Pop();
            }
            if (numbers.Contains(cmd[2]))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count < 1)
            {
                Console.WriteLine(numbers.Count);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
