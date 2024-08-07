namespace OffroadChallenge
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int possitionRow = 0;
            int possitionCol = 0;

            for (int i = 0; i < n; i++)
            {
                char[] rowValues = Console.ReadLine()
                    .ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowValues[j];
                    if (rowValues[j] == 'G')
                    {
                        possitionRow = i;
                        possitionCol = j;
                        matrix[i, j] = '-';
                    }
                }
            }

            int totalAmount = 100;
            bool isJackpotWins = false;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "up")
                {
                    if (IsValidIndexes(n, n, possitionRow - 1, possitionCol))
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        break;
                    }
                    possitionRow -= 1;

                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'W')
                    {
                        totalAmount += 100;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'P')
                    {
                        totalAmount -= 200;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'J')
                    {
                        totalAmount += 100000;
                        isJackpotWins = true;
                        break;
                    }
                    if (totalAmount <= 0)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }

                }
                else if (command == "down")
                {
                    if (IsValidIndexes(n, n, possitionRow + 1, possitionCol))
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        break;
                    }
                    possitionRow += 1;

                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'W')
                    {
                        totalAmount += 100;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'P')
                    {
                        totalAmount -= 200;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'J')
                    {
                        totalAmount += 100000;
                        isJackpotWins = true;
                        break;
                    }
                    if (totalAmount <= 0)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }
                }
                else if (command == "left")
                {
                    if (IsValidIndexes(n, n, possitionRow, possitionCol - 1))
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        break;
                    }
                    possitionCol -= 1;

                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'W')
                    {
                        totalAmount += 100;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'P')
                    {
                        totalAmount -= 200;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'J')
                    {
                        totalAmount += 100000;
                        isJackpotWins = true;
                        break;
                    }
                    if (totalAmount <= 0)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }
                }
                else if (command == "right")
                {
                    if (IsValidIndexes(n, n, possitionRow, possitionCol + 1))
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        break;
                    }
                    possitionCol += 1;

                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'W')
                    {
                        totalAmount += 100;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'P')
                    {
                        totalAmount -= 200;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'J')
                    {
                        totalAmount += 100000;
                        isJackpotWins = true;
                        break;
                    }
                    if (totalAmount <= 0)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }
                }
            }
            if (isJackpotWins)
            {
                Console.WriteLine("You win the Jackpot!");
                Console.WriteLine($"End of the game. Total amount: {totalAmount}$");
            }
            else if (!isJackpotWins)
            {
                Console.WriteLine($"End of the game. Total amount: {totalAmount}$");
            }
            if (totalAmount > 0)
            {
                matrix[possitionRow, possitionCol] = 'G';
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