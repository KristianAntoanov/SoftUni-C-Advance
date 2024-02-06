namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>(Console.ReadLine()
                .Split());
            int n = int.Parse(Console.ReadLine());
            while (names.Count > 1)
            {
                for (int i = 0; i < n; i++)
                {
                    string currName = names.Dequeue();
                    if (i == n - 1)
                    {
                        Console.WriteLine($"Removed {currName}");
                    }
                    else
                    {
                        names.Enqueue(currName);
                    }
                }
            }
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
