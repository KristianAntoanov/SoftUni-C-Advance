namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nM = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = nM[0];
            int m = nM[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            HashSet<int> uniqueElements = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    uniqueElements.Add(item);
                }
            }
            foreach (var item in uniqueElements)
            {
                Console.Write(item + " ");
            }
        }
    }
}
