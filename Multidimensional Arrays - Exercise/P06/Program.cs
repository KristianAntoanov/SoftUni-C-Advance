namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedMatrix = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jaggedMatrix[row] = rowValues;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (jaggedMatrix[i].Length == jaggedMatrix[i + 1].Length)
                {
                    jaggedMatrix[i] = jaggedMatrix[i].Select(x => x * 2).ToArray();
                    jaggedMatrix[i + 1] = jaggedMatrix[i + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[i] = jaggedMatrix[i].Select(x => x / 2).ToArray();
                    jaggedMatrix[i + 1] = jaggedMatrix[i + 1].Select(x => x / 2).ToArray();
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                if (cmdType == "Add")
                {
                    AddAndSubtractElementsOfMatrix(jaggedMatrix, cmdArgs);
                }
                else if (cmdType == "Subtract")
                {
                    AddAndSubtractElementsOfMatrix(jaggedMatrix, cmdArgs);
                }
            }
            PrintMatrix(jaggedMatrix);
        }

        static void AddAndSubtractElementsOfMatrix(int[][] jaggedMatrix, string[] cmdArgs)
        {
            int rowIndex = int.Parse(cmdArgs[1]);
            int colIndex = int.Parse(cmdArgs[2]);
            int value = int.Parse(cmdArgs[3]);
            if (cmdArgs[0] == "Add")
            {
                if (rowIndex >= 0 && colIndex >= 0 &&
                    rowIndex < jaggedMatrix.GetLength(0) &&
                    colIndex < jaggedMatrix[rowIndex].Length)
                {
                    jaggedMatrix[rowIndex][colIndex] += value;
                }
            }
            else
            {
                if (rowIndex >= 0 && colIndex >= 0 &&
                    rowIndex < jaggedMatrix.GetLength(0) &&
                    colIndex < jaggedMatrix[rowIndex].Length)
                {
                    jaggedMatrix[rowIndex][colIndex] -= value;
                }
            }
        }

        static void PrintMatrix(int[][] matrix)
        {
            foreach (int[] item in matrix)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
