namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clotesInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clotes = new Stack<int>(clotesInfo);

            int counter = 0;
            while (clotes.Any())
            {
                int checkForCapacity = rackCapacity;
                counter++;
                while (checkForCapacity >= clotes.Peek())
                {
                    if (checkForCapacity >= clotes.Peek())
                    {
                        checkForCapacity -= clotes.Pop();
                    }
                    if (!clotes.Any())
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
