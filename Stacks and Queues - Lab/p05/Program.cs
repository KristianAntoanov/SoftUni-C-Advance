namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> input = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 == 0));
            Console.WriteLine(string.Join(", ", input.Select(x => x.ToString())));
        }
    }
}
