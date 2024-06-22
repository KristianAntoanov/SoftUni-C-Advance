namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = x => x[0] == char.ToUpper(x[0]);

            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
                
        }
    }
}