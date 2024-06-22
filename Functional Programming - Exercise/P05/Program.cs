namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Action<List<int>> printer = x => Console.WriteLine(String.Join(" ", x));
            Func<string, List<int>, List<int>> calculate = (commands, numbers) => 
            {
                List<int> result = new List<int>();
                foreach (var currNum in numbers)
                {
                    if (commands == "add")
                    {
                        result.Add(currNum + 1);
                    }
                    else if (commands == "multiply")
                    {
                        result.Add(currNum * 2);
                    }
                    else if (commands == "subtract")
                    {
                        result.Add(currNum - 1);
                    }
                }
                return result;
            };

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "end")
            {
                if (commands == "print")
                {
                    printer(numbers);
                }
                else
                {
                    numbers = calculate(commands, numbers);
                }
            }

        }
    }
}
