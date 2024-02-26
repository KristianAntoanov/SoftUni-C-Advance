namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int row = input[0];
            int col = input[1];

            int[,] matrix = new int[row, col];
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rowValues[j];
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(sum);
        }
    }
}
