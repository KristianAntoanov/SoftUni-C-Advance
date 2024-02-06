namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                stack.Push(currChar);
            }
            foreach (var item in stack)
            {
                Console.Write(item);
            }
        }
    }
}