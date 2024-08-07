namespace OffroadChallenge
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            int possitionRow = 0;
            int possitionCol = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                char[] rowValues = Console.ReadLine()
                    .ToCharArray();
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = rowValues[j];
                    if (rowValues[j] == 'S')
                    {
                        possitionRow = i;
                        possitionCol = j;
                        matrix[i, j] = '-';
                    }
                }
            }
            int quotаToReached = 0;

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "collect the nets")
            {
                if (commands == "up")
                {
                    if (IsValidIndexes(matrixSize, matrixSize, possitionRow - 1, possitionCol))
                    {
                        possitionRow = possitionRow + matrixSize - 1;
                    }
                    else
                    {
                        possitionRow -= 1;
                    }
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{possitionRow},{possitionCol}]");
                        return;
                    }
                    else if (currChar != '-')
                    {
                        int currTonesOfFish = int.Parse(currChar.ToString());
                        quotаToReached += currTonesOfFish;
                        matrix[possitionRow, possitionCol] = '-';
                    }

                }
                else if (commands == "down")
                {
                    if (IsValidIndexes(matrixSize, matrixSize, possitionRow + 1, possitionCol))
                    {
                        possitionRow = 0;
                    }
                    else
                    {
                        possitionRow += 1;
                    }
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{possitionRow},{possitionCol}]");
                        return;
                    }
                    else if (currChar != '-')
                    {
                        int currTonesOfFish = int.Parse(currChar.ToString());
                        quotаToReached += currTonesOfFish;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                }
                else if (commands == "left")
                {
                    if (IsValidIndexes(matrixSize, matrixSize, possitionRow, possitionCol - 1))
                    {
                        possitionCol = possitionCol + matrixSize - 1;
                    }
                    else
                    {
                        possitionCol -= 1;
                    }
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{possitionRow},{possitionCol}]");
                        return;
                    }
                    else if (currChar != '-')
                    {
                        int currTonesOfFish = int.Parse(currChar.ToString());
                        quotаToReached += currTonesOfFish;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                }
                else if (commands == "right")
                {
                    if (IsValidIndexes(matrixSize, matrixSize, possitionRow, possitionCol + 1))
                    {
                        possitionCol = 0;
                    }
                    else
                    {
                        possitionCol += 1;
                    }
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{possitionRow},{possitionCol}]");
                        return;
                    }
                    else if (currChar != '-')
                    {
                        int currTonesOfFish = int.Parse(currChar.ToString());
                        quotаToReached += currTonesOfFish;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                }
            }

            if (quotаToReached >= 20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else if (quotаToReached < 20)
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - quotаToReached} tons of fish more.");
            }
            if (quotаToReached > 0)
            {
                Console.WriteLine($"Amount of fish caught: {quotаToReached} tons.");
            }
            if (commands == "collect the nets")
            {
                matrix[possitionRow, possitionCol] = 'S';
                PrintMatrix(matrix);
            }

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