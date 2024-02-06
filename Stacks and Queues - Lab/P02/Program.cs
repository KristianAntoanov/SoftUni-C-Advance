namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            string input = string.Empty;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArg = input
                    .Split()
                    .ToArray();

                if (cmdArg[0] == "add")
                {
                    int num1 = int.Parse(cmdArg[1]);
                    int num2 = int.Parse(cmdArg[2]);
                    numbers.Push(num1);
                    numbers.Push(num2);
                }
                else if (cmdArg[0] == "remove")
                {
                    int num = int.Parse(cmdArg[1]);
                    if (numbers.Count > num)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
                
        }
    }
}