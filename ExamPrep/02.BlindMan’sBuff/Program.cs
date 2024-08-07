namespace BlindMansBuff
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] ColAndRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int row = ColAndRow[0];
            int col = ColAndRow[1];
            char[,] matrix = new char[row, col];

            int currRow = 0;
            int currCol = 0;

            for (int i = 0; i < row; i++)
            {
                char[] rowValues = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rowValues[j];
                    if (rowValues[j] == 'B')
                    {
                        currRow = i;
                        currCol = j;
                    }
                }
            }

            int touchedOpponents = 0;
            int moves = 0;

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "Finish")
            {
                if (commands == "up")
                {
                    if (!ValidateMove(matrix, currRow - 1, currCol))
                    {
                        continue;
                    }
                    moves++;
                    currRow -= 1;
                    char currChar = matrix[currRow, currCol];
                    matrix[currRow, currCol] = '-';
                    if (currChar == 'P')
                    {
                        touchedOpponents++;
                    }
                    matrix[currRow, currCol] = 'B';
                }
                else if (commands == "down")
                {
                    if (!ValidateMove(matrix, currRow + 1, currCol))
                    {
                        continue;
                    }
                    moves++;
                    currRow += 1;
                    char currChar = matrix[currRow, currCol];
                    matrix[currRow, currCol] = '-';
                    if (currChar == 'P')
                    {
                        touchedOpponents++;
                    }
                    matrix[currRow, currCol] = 'B';
                }
                else if (commands == "left")
                {
                    if (!ValidateMove(matrix, currRow, currCol - 1))
                    {
                        continue;
                    }
                    moves++;
                    currCol -= 1;
                    char currChar = matrix[currRow, currCol];
                    matrix[currRow, currCol] = '-';
                    if (currChar == 'P')
                    {
                        touchedOpponents++;
                    }
                    matrix[currRow, currCol] = 'B';
                }
                else if (commands == "right")
                {
                    if (!ValidateMove(matrix, currRow, currCol + 1))
                    {
                        continue;
                    }
                    moves++;
                    currCol += 1;
                    char currChar = matrix[currRow, currCol];
                    matrix[currRow, currCol] = '-';
                    if (currChar == 'P')
                    {
                        touchedOpponents++;
                    }
                    matrix[currRow, currCol] = 'B';
                }
                if (touchedOpponents == 3)
                {
                    break;
                }
            }
            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touchedOpponents} Moves made: {moves}");
        }
        static bool ValidateMove(char[,] matrix, int row, int col)
        {
            bool result = row >= 0
                && row < matrix.GetLength(0)
                && col >= 0
                && col < matrix.GetLength(1)
                && matrix[row, col] != 'O';

            return result;
        }
    }
}