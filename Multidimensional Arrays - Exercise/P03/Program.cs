namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                int[] rowValue = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = rowValue[col];
                }
            }

            int maxSquareSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < input[0] - 2; row++)
            {

                for (int col = 0; col < input[1] - 2; col++)
                {
                    int currSum = matrix[row + 1, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col + 1] +
                        matrix[row + 1, col + 2] +
                        matrix[row + 2, col + 1] +
                        matrix[row, col + 2] +
                        matrix[row + 2, col] +
                        matrix[row + 2, col + 2] +
                        matrix[row, col];
                    if (currSum > maxSquareSum)
                    {
                        maxSquareSum = currSum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSquareSum}");
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
