namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                if (expression[i] == ')')
                {
                    int openBracket = indexes.Pop();

                    Console.WriteLine(expression.Substring(openBracket, i - openBracket + 1));
                }
            }
        }
    }
}