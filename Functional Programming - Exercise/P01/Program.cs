namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                
            Action<List<string>> printer = x => Console.WriteLine($"{String.Join(Environment.NewLine,x)}");

            printer(names);
        }
    }
}
