namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] rowValue = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                matrix[i] = rowValue;
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input
                    .Split();
                    int row = int.Parse(cmdArgs[1]);
                    int col = int.Parse(cmdArgs[2]);
                    int value = int.Parse(cmdArgs[3]);
                if (cmdArgs[0] == "Add")
                {
                    if (row < 0 || col < 0 || row >= matrix.Length
                        || matrix[row].Length <= col)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                    matrix[row][col] += value;
                }
                else if (cmdArgs[0] == "Subtract")
                {
                    if (row < 0 || col < 0 ||row >= matrix.Length
                        || matrix[row].Length <= col)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                    matrix[row][col] -= value;
                }
            }
            foreach (int[] row in matrix)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
