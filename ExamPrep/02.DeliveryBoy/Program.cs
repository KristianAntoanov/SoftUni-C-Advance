namespace DeliveryBoy
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
            char[,] matrix = new char[ColAndRow[0], ColAndRow[1]];

            int currRow = 0;
            int currCol = 0;
            int startRow = 0;
            int startCol = 0;

            for (int i = 0; i < row; i++)
            {
                char[] rowValues = Console.ReadLine()
                    .ToCharArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rowValues[j];
                    if (rowValues[j] == 'B')
                    {
                        currRow = i;
                        currCol = j;
                        startRow = i;
                        startCol = j;
                    }
                }
            }

            string command = string.Empty;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "up")
                {
                    if (IsValidIndexes(row, col, currRow - 1, currCol))
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        matrix[startRow, startCol] = ' ';
                        break;
                    }
                    currRow -= 1;
                    char currChar = matrix[currRow, currCol];
                    if (currChar == '*')
                    {
                        currRow += 1;
                    }
                    else if (currChar == 'P')
                    {
                        matrix[currRow, currCol] = 'R';
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                    }
                    else if (currChar == 'A')
                    {
                        matrix[currRow, currCol] = 'P';
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        break;
                    }
                    else if (currChar == '-')
                    {
                        matrix[currRow, currCol] = '.';
                    }
                    matrix[startRow, startCol] = 'B';
                }
                else if (command == "down")
                {
                    if (IsValidIndexes(row, col, currRow + 1, currCol))
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        matrix[startRow, startCol] = ' ';
                        break;
                    }
                    currRow += 1;
                    char currChar = matrix[currRow, currCol];
                    if (currChar == '*')
                    {
                        currRow -= 1;
                    }
                    else if (currChar == 'P')
                    {
                        matrix[currRow, currCol] = 'R';
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                    }
                    else if (currChar == 'A')
                    {
                        matrix[currRow, currCol] = 'P';
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        break;
                    }
                    else if (currChar == '-')
                    {
                        matrix[currRow, currCol] = '.';
                    }
                    matrix[startRow, startCol] = 'B';
                }
                else if (command == "left")
                {
                    if (IsValidIndexes(row, col, currRow, currCol - 1))
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        matrix[startRow, startCol] = ' ';
                        break;
                    }
                    currCol -= 1;
                    char currChar = matrix[currRow, currCol];
                    if (currChar == '*')
                    {
                        currCol += 1;
                    }
                    else if (currChar == 'P')
                    {
                        matrix[currRow, currCol] = 'R';
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                    }
                    else if (currChar == 'A')
                    {
                        matrix[currRow, currCol] = 'P';
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        break;
                    }
                    else if (currChar == '-')
                    {
                        matrix[currRow, currCol] = '.';
                    }
                    matrix[startRow, startCol] = 'B';
                }
                else if (command == "right")
                {
                    if (IsValidIndexes(row, col, currRow, currCol + 1))
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        matrix[startRow, startCol] = ' ';
                        break;
                    }
                    currCol += 1;
                    char currChar = matrix[currRow, currCol];
                    if (currChar == '*')
                    {
                        currCol -= 1;
                    }
                    else if (currChar == 'P')
                    {
                        matrix[currRow, currCol] = 'R';
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                    }
                    else if (currChar == 'A')
                    {
                        matrix[currRow, currCol] = 'P';
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        break;
                    }
                    else if (currChar == '-')
                    {
                        matrix[currRow, currCol] = '.';
                    }
                    matrix[startRow, startCol] = 'B';
                }
            }

            PrintMatrix(matrix);
        }
        static bool IsValidIndexes(int row, int col, int currRow, int currCol)
        => currRow < 0 || currCol < 0 || currRow >= row || currCol >= col;
        static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}