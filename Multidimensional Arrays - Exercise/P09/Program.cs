namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[n, n];
            int currRow = 0;
            int currCol = 0;
            int countAllCoal = 0;
            for (int i = 0; i < n; i++)
            {
                char[] rowValues = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowValues[j];
                    if (rowValues[j] == 's')
                    {
                        currRow = i;
                        currCol = j;
                    }
                    else if (rowValues[j] == 'c')
                    {
                        countAllCoal++;
                    }
                }
            }
            int coalCollect = 0;
            foreach (var dir in directions)
            {
                if (dir == "left")
                {
                    if (currCol - 1 >= 0)
                    {
                        currCol--;
                        char currChar = matrix[currRow, currCol];
                        if (currChar == 'c')
                        {
                            countAllCoal--;
                            matrix[currRow, currCol] = '*';
                        }
                        else if (currChar == 'e')
                        {
                            Console.WriteLine($"Game over! ({currRow}, {currCol})");
                            return;
                        }
                    }
                }
                else if (dir == "right")
                {
                    if (currCol + 1 <= n - 1)
                    {
                        currCol++;
                        char currChar = matrix[currRow, currCol];
                        if (currChar == 'c')
                        {
                            countAllCoal--;
                            matrix[currRow, currCol] = '*';
                        }
                        else if (currChar == 'e')
                        {
                            Console.WriteLine($"Game over! ({currRow}, {currCol})");
                            return;
                        }
                    }
                }
                else if (dir == "up")
                {
                    if (currRow - 1 >= 0)
                    {
                        currRow--;
                        char currChar = matrix[currRow, currCol];
                        if (currChar == 'c')
                        {
                            countAllCoal--;
                            matrix[currRow, currCol] = '*';
                        }
                        else if (currChar == 'e')
                        {
                            Console.WriteLine($"Game over! ({currRow}, {currCol})");
                            return;
                        }
                    }
                }
                else if (dir == "down")
                {
                    if (currRow + 1 <= n - 1)
                    {
                        currRow++;
                        char currChar = matrix[currRow, currCol];
                        if (currChar == 'c')
                        {
                            countAllCoal--;
                            matrix[currRow, currCol] = '*';
                        }
                        else if (currChar == 'e')
                        {
                            Console.WriteLine($"Game over! ({currRow}, {currCol})");
                            return;
                        }
                    }
                }
                else
                {
                    // ? if i need 
                }
                if (countAllCoal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                    break;
                }
            }
            if (countAllCoal != 0)
            {
                Console.WriteLine($"{countAllCoal} coals left. ({currRow}, {currCol})");
            }

        }
    }
}
