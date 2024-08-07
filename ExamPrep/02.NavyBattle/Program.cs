namespace NavyBattle
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
                    if (rowValues[j] == 'S')
                    {
                        possitionRow = i;
                        possitionCol = j;
                        matrix[i, j] = '-';
                    }
                }
            }

            int acrossMine = 0;
            int cruisers = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    possitionRow -= 1;
                    char currChar = matrix[possitionRow, possitionCol];

                    if (currChar == '*')
                    {
                        acrossMine++;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'C')
                    {
                        cruisers++;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    if (acrossMine == 3 || cruisers == 3)
                    {
                        break;
                    }
                }
                else if (command == "down")
                {
                    possitionRow += 1;
                    char currChar = matrix[possitionRow, possitionCol];

                    if (currChar == '*')
                    {
                        acrossMine++;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'C')
                    {
                        cruisers++;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    if (acrossMine == 3 || cruisers == 3)
                    {
                        break;
                    }
                }
                else if (command == "left")
                {
                    possitionCol -= 1;
                    char currChar = matrix[possitionRow, possitionCol];

                    if (currChar == '*')
                    {
                        acrossMine++;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'C')
                    {
                        cruisers++;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    if (acrossMine == 3 || cruisers == 3)
                    {
                        break;
                    }
                }
                else if (command == "right")
                {
                    possitionCol += 1;
                    char currChar = matrix[possitionRow, possitionCol];

                    if (currChar == '*')
                    {
                        acrossMine++;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    else if (currChar == 'C')
                    {
                        cruisers++;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    if (acrossMine == 3 || cruisers == 3)
                    {
                        break;
                    }
                }
            }
            matrix[possitionRow, possitionCol] = 'S';
            if (cruisers == 3)
            {
                Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            }
            if (acrossMine == 3)
            {
                Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{possitionRow}, {possitionCol}]!");
            }
            PrintMatrix(matrix);
        }
        //static bool ValidateMove(char[,] matrix, int row, int col) => row >= 0 && col >= 0
        //        && row < matrix.GetLength(0) && col < matrix.GetLength(1);
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