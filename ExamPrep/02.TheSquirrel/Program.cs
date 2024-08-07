namespace TheSquirrel
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> commands = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

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
                    if (rowValues[j] == 's')
                    {
                        possitionRow = i;
                        possitionCol = j;
                        matrix[i, j] = '*';
                    }
                }
            }
            bool isStepOnTrap = false;
            bool isOutOfField = false;
            int hazelnut = 0;
            for (int i = 0; i < commands.Count; i++)
            {
                if (commands[i] == "up")
                {
                    if (IsValidIndexes(n, n, possitionRow - 1, possitionCol))
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        isOutOfField = true;
                        break;
                    }
                    possitionRow -= 1;
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'h')
                    {
                        hazelnut++;
                        matrix[possitionRow, possitionCol] = '*';
                    }
                    else if (currChar == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        isStepOnTrap = true;
                        break;
                    }
                    if (hazelnut == 3)
                    {
                        Console.WriteLine("Good job! You have collected all hazelnuts!");
                        break;
                    }
                }
                else if (commands[i] == "down")
                {
                    if (IsValidIndexes(n, n, possitionRow + 1, possitionCol))
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        isOutOfField = true;
                        break;
                    }
                    possitionRow += 1;
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'h')
                    {
                        hazelnut++;
                        matrix[possitionRow, possitionCol] = '*';
                    }
                    else if (currChar == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        isStepOnTrap = true;
                        break;
                    }
                    if (hazelnut == 3)
                    {
                        Console.WriteLine("Good job! You have collected all hazelnuts!");
                        break;
                    }
                }
                else if (commands[i] == "left")
                {
                    if (IsValidIndexes(n, n, possitionRow, possitionCol - 1))
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        isOutOfField = true;
                        break;
                    }
                    possitionCol -= 1;
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'h')
                    {
                        hazelnut++;
                        matrix[possitionRow, possitionCol] = '*';
                    }
                    else if (currChar == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        isStepOnTrap = true;
                        break;
                    }
                    if (hazelnut == 3)
                    {
                        Console.WriteLine("Good job! You have collected all hazelnuts!");
                        break;
                    }
                }
                else if (commands[i] == "right")
                {
                    if (IsValidIndexes(n, n, possitionRow, possitionCol + 1))
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        isOutOfField = true;
                        break;
                    }
                    possitionCol += 1;
                    char currChar = matrix[possitionRow, possitionCol];
                    if (currChar == 'h')
                    {
                        hazelnut++;
                        matrix[possitionRow, possitionCol] = '*';
                    }
                    else if (currChar == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        isStepOnTrap = true;
                        break;
                    }
                    if (hazelnut == 3)
                    {
                        Console.WriteLine("Good job! You have collected all hazelnuts!");
                        break;
                    }
                }
            }
            if (hazelnut < 3 && !isStepOnTrap && !isOutOfField)
            {
                Console.WriteLine("There are more hazelnuts to collect.");
            }
            Console.WriteLine($"Hazelnuts collected: {hazelnut}");

        }
        static bool IsValidIndexes(int row, int col, int currRow, int currCol)
        => currRow < 0 || currCol < 0 || currRow >= row || currCol >= col;
    }
}
