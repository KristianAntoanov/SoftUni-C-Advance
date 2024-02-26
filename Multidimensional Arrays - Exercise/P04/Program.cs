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
            string[,] matrix = new string[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                string[] rowValue = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = rowValue[col];
                }
            }

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = commands
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = matrix.GetLength(0);
                int col = matrix.GetLength(1);
                if (cmdArgs.Length > 5 || cmdArgs.Length < 0 || cmdArgs.Length < 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int rowCordinates1 = int.Parse(cmdArgs[1]); 
                int colCordinates1 = int.Parse(cmdArgs[2]); 
                int rowCordinates2 = int.Parse(cmdArgs[3]); 
                int colCordinates2 = int.Parse(cmdArgs[4]); 
                if (cmdArgs[0] != "swap" ||rowCordinates1 < 0 || rowCordinates1 > row || colCordinates1 < 0 ||
                    colCordinates1 > col || rowCordinates2 < 0 || rowCordinates2 > row || colCordinates2 < 0 ||
                    colCordinates2 > col)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string charToSwap = matrix[rowCordinates1, colCordinates1];

                matrix[rowCordinates1, colCordinates1] = matrix[rowCordinates2, colCordinates2];
                matrix[rowCordinates2, colCordinates2] = charToSwap;
                PrintMatrix(matrix);
            }
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
