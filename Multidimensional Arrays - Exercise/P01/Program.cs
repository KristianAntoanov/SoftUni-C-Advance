namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int primaryD = 0;
            int secondaryD = 0;
            for (int row = 0; row < n; row++)
            {
                int[] rowValue = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowValue[col];
                }
                    //primaryD += rowValue[row]; - it's another way to sum primary Diagonal
            }
            for (int i = 0; i < n; i++)  
            {
                primaryD += matrix[i, i];
                secondaryD += matrix[i, n - 1 - i];
            }
            Console.WriteLine(Math.Abs(primaryD - secondaryD));
        }
    }
}
