namespace P02
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
            int enemyAircraft = 0;

            for (int i = 0; i < n; i++)
            {
                char[] rowValues = Console.ReadLine()
                    .ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowValues[j];
                    if (rowValues[j] == 'J')
                    {
                        possitionRow = i;
                        possitionCol = j;
                        matrix[i, j] = '-';
                    }
                    if (rowValues[j] == 'E')
                    {
                        enemyAircraft++;
                    }
                }
            }

            int armor = 300;
            int shootedEnemy = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    possitionRow -= 1;
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'E')
                    {
                        armor -= 100;
                        matrix[possitionRow, possitionCol] = '-';
                        shootedEnemy++;
                    }
                    if (armor < 1)
                    {
                        Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{possitionRow}, {possitionCol}]!");
                        break;
                    }
                    if (currChar == 'R')
                    {
                        armor = 300;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    if (shootedEnemy == enemyAircraft)
                    {
                        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                        break;
                    }
                }
                else if (command == "down")
                {
                    possitionRow += 1;
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'E')
                    {
                        armor -= 100;
                        matrix[possitionRow, possitionCol] = '-';
                        shootedEnemy++;
                    }
                    if (armor < 1)
                    {
                        Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{possitionRow}, {possitionCol}]!");
                        break;
                    }
                    if (currChar == 'R')
                    {
                        armor = 300;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    if (shootedEnemy == enemyAircraft)
                    {
                        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                        break;
                    }
                }
                else if (command == "left")
                {
                    possitionCol -= 1;
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'E')
                    {
                        armor -= 100;
                        matrix[possitionRow, possitionCol] = '-';
                        shootedEnemy++;
                    }
                    if (armor < 1)
                    {
                        Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{possitionRow}, {possitionCol}]!");
                        break;
                    }
                    if (currChar == 'R')
                    {
                        armor = 300;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    if (shootedEnemy == enemyAircraft)
                    {
                        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                        break;
                    }
                }
                else if (command == "right")
                {
                    possitionCol += 1;
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'E')
                    {
                        armor -= 100;
                        matrix[possitionRow, possitionCol] = '-';
                        shootedEnemy++;
                    }
                    if (armor < 1)
                    {
                        Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{possitionRow}, {possitionCol}]!");
                        break;
                    }
                    if (currChar == 'R')
                    {
                        armor = 300;
                        matrix[possitionRow, possitionCol] = '-';
                    }
                    if (shootedEnemy == enemyAircraft)
                    {
                        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                        break;
                    }
                }
            }
            matrix[possitionRow, possitionCol] = 'J';
            PrintMatrix(matrix);
        }
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