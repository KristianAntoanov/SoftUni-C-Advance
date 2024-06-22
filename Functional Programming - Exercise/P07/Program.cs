namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<int> isValidName = x => x <= n;
            Action<string> printer = x => Console.WriteLine(x);

            foreach (var item in names)
            {
                if (isValidName(item.Length))
                {
                    printer(item);
                }
            }
        }
    }
}
