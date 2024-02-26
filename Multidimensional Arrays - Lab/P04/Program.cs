namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] charMatrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] rowValue = Console.ReadLine()
                    .ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    charMatrix[i, j] = rowValue[j];
                }
            }
            char crToFind = char.Parse(Console.ReadLine());

            bool isFound = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (charMatrix[i, j] == crToFind)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{crToFind} does not occur in the matrix");
            }
        }
    }
}
