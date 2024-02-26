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
            char[,] matrix = new char[input[0], input[1]];

            int count = 0;
            for (int row = 0; row < input[0]; row++)
            {
                char[] rowValue = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = rowValue[col];
                }
            }

            for (int row = 0; row < input[0] - 1; row++)
            {

                for (int col = 0; col< input[1] - 1; col++)
                {
                    char currChar = matrix[row, col];
                    if (currChar == matrix[row + 1, col + 1] && currChar == matrix[row + 1, col] && currChar == matrix[row, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
