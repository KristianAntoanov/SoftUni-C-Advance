namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] knightMatrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] rowValues = Console.ReadLine()
                    .ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    knightMatrix[i, j] = rowValues[j];
                }
            }
            if (n < 3)
            {
                Console.WriteLine(0);
                return;
            }
            int count = - 1;
            while (true)
            {
                int countOfAttacks = 0;
                int rowKnightToRemove = 0;
                int colKnightToRemove = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        char currChar = knightMatrix[i, j];
                        if (currChar == 'K')
                        {
                            int currCount = CalculateAttackedKnight(i, j, knightMatrix);
                            if (currCount > countOfAttacks)
                            {
                                countOfAttacks = currCount;
                                rowKnightToRemove = i;
                                colKnightToRemove = j;
                            }
                        }
                    }
                }
                knightMatrix[rowKnightToRemove, colKnightToRemove] = '0';
                count++;
                if (countOfAttacks == 0)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }

        static int CalculateAttackedKnight(int row, int col, char[,] knightMatrix)
        {
            int count = 0;
            if (IsValidIndexes(row - 2, col + 1, knightMatrix.GetLength(0)))
            {

                char currElement = knightMatrix[row - 2, col + 1];
                if (currElement == 'K')
                {
                    count++;
                }
            }
            if (IsValidIndexes(row - 2, col - 1, knightMatrix.GetLength(0)))
            {

                char currElement = knightMatrix[row - 2, col - 1];
                if (currElement == 'K')
                {
                    count++;
                }
            }
            if (IsValidIndexes(row + 2, col + 1, knightMatrix.GetLength(0)))
            {

                char currElement = knightMatrix[row + 2, col + 1];
                if (currElement == 'K')
                {
                    count++;
                }
            }
            if (IsValidIndexes(row + 2, col - 1, knightMatrix.GetLength(0)))
            {

                char currElement = knightMatrix[row + 2, col - 1];
                if (currElement == 'K')
                {
                    count++;
                }
            }
            if (IsValidIndexes(row - 1, col + 2, knightMatrix.GetLength(0)))
            {

                char currElement = knightMatrix[row - 1, col + 2];
                if (currElement == 'K')
                {
                    count++;
                }
            }
            if (IsValidIndexes(row + 1, col + 2, knightMatrix.GetLength(0)))
            {

                char currElement = knightMatrix[row + 1, col + 2];
                if (currElement == 'K')
                {
                    count++;
                }
            }
            if (IsValidIndexes(row + 1, col - 2, knightMatrix.GetLength(0)))
            {

                char currElement = knightMatrix[row + 1, col - 2];
                if (currElement == 'K')
                {
                    count++;
                }
            }
            if (IsValidIndexes(row - 1, col - 2, knightMatrix.GetLength(0)))
            {

                char currElement = knightMatrix[row - 1, col - 2];
                if (currElement == 'K')
                {
                    count++;
                }
            }
            return count;
        }
        static bool IsValidIndexes(int row, int col, int n)
        => row >= 0 && col >= 0 && row < n && col < n;
        
    }
}
