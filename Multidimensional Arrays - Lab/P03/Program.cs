    namespace MyApp // Note: actual namespace depends on the project name.
    {
        using System;

        internal class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                int[,] matrix = new int[n, n];

                int diagonalSum = 0;
                for (int i = 0; i < n; i++)
                {
                    int[] rowValues = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = rowValues[j];
                    }
                        diagonalSum += rowValues[i];
                }
                Console.WriteLine(diagonalSum);
            }
        }
    }
