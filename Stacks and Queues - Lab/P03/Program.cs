namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            Stack<string> expression = new Stack<string>();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                expression.Push(input[i]);
            }
            int currResult = int.Parse(expression.Pop());
            while (expression.Count > 0)
            {
                char currOperator = char.Parse(expression.Pop());
                int secondNum = int.Parse(expression.Pop());
                if (currOperator == '+')
                {
                    currResult += secondNum;
                }
                else
                {
                    currResult -= secondNum;
                }
            }
            Console.WriteLine(currResult);

        }
    }
}
