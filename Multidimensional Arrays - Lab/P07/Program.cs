    namespace MyApp // Note: actual namespace depends on the project name.
    {
        using System;

        internal class Program
        {
            static void Main(string[] args)
            {
                long n = int.Parse(Console.ReadLine());


                long[][] pascal = new long[n][];

                pascal[0] = new long[1] { 1 };

                for (long row = 1; row < n; row++)
                {
                    pascal[row] = new long[row + 1];
                    for (long col = 0; col < pascal[row].Length; col++)
                    {
                        if (col < pascal[row - 1].Length)
                        {
                            pascal[row][col] += pascal[row - 1][col];
                        }
                        if (col > 0)
                        {
                            pascal[row][col] += pascal[row - 1][col - 1];
                        }
                    }
                }
 
                for (int i = 0; i < pascal.Length; i++)
                {
                    for (int j = 0; j < pascal[i].Length; j++)
                    {  
                        Console.Write(pascal[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
