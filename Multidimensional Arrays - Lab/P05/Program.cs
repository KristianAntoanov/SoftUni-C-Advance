namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = input[0];
            int cols = input[1];

            int cubeRow = int.Parse(Console.ReadLine());
            int cubeCol = int.Parse(Console.ReadLine());    

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowValue = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowValue[j];
                }
            }
            //----------------------------------------------
            int maxSquareRow = 0;
            int maxSquareCol = 0;
            int maxSquareSum = int.MinValue;
            int currMaxSquareSum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i + cubeRow < rows + 1)
                    {
                        for (int k = i; k < cubeRow + i; k++)
                        {
                            if (j + cubeCol < cols + 1)
                            {
                                for (int o = j; o < cubeCol + j; o++)
                                {
                                    currMaxSquareSum += matrix[k, o];
                                    if (currMaxSquareSum > maxSquareSum)
                                    {
                                        maxSquareSum = currMaxSquareSum;
                                        maxSquareRow = i;
                                        maxSquareCol = j;
                                    }
                                }
                            }
                        }
                        currMaxSquareSum = 0;
                    }

                    //int currMaxSquare =
                    //    matrix[i, j] +
                    //    matrix[i, j + 1] +
                    //    matrix[i + 1, j] +
                    //    matrix[i + 1, j + 1];
                    //if (currMaxSquare > maxSquareSum)
                    //{
                    //    maxSquareSum = currMaxSquare;
                    //    maxSquareRow = i;
                    //    maxSquareCol = j;
                    //}
                }
            }
            Console.WriteLine(maxSquareSum);
            Console.WriteLine(maxSquareRow);
            Console.WriteLine(maxSquareCol);
            for (int i = maxSquareRow; i < cubeRow + maxSquareRow; i++)
            {
                for (int j = maxSquareCol; j < cubeCol + maxSquareCol; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine($"{matrix[maxSquareRow, maxSquareCol]} {matrix[maxSquareRow, maxSquareCol + 1]}");
            //Console.WriteLine($"{matrix[maxSquareRow + 1, maxSquareCol]} {matrix[maxSquareRow + 1, maxSquareCol + 1]}");
            //Console.WriteLine(maxSquareSum);
        }
    }
}
