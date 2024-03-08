namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> countOfIntegers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (!countOfIntegers.ContainsKey(currNumber))
                {
                    countOfIntegers[currNumber] = 0;
                }
                countOfIntegers[currNumber]++;
            }
            foreach (var item in countOfIntegers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
