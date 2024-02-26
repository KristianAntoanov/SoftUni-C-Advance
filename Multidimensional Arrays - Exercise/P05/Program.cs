namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string text = Console.ReadLine();

            char[,] snakemMatrix = new char[cordinates[0], cordinates[1]];

            Queue<char> crForMatrix = new Queue<char>();

            string reversedText = ReverseString(text);
            int index = 0;
            for (int i = 0; i < cordinates[0] * cordinates[1]; i++)
            {
                crForMatrix.Enqueue(text[index]);
                if (index >= text.Length - 1)
                {
                    index = -1;
                }
                index++;
            }

            for (int i = 0; i < cordinates[0]; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cordinates[1]; j++)
                    {
                        snakemMatrix[i, j] = crForMatrix.Dequeue();
                    }
                }
                else
                {
                    for (int k = cordinates[1] - 1; k >= 0; k--)
                    {
                        snakemMatrix[i, k] = crForMatrix.Dequeue();
                    }
                }
            }

            for (int i = 0; i < cordinates[0]; i++)
            {
                for (int j = 0; j < cordinates[1]; j++)
                {
                    Console.Write(snakemMatrix[i, j]);
                }
                Console.WriteLine();
            }

        }
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
