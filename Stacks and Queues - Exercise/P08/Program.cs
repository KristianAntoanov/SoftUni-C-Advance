namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();

            Stack<char> cr = new Stack<char>();

            bool isBalanced = true;
            for (int i = 0; i < parentheses.Length; i++)
            {
                char currChar = parentheses[i];
                if (currChar == '{' || currChar == '(' || currChar == '[' || currChar == ' ')
                {
                    cr.Push(currChar);
                }
                else
                {
                    if (currChar == '}')
                    {
                        if (cr.Count == 0 || cr.Pop() != '{')
                        {
                            isBalanced = false;
                        }
                    }
                    else if (currChar == ')')
                    {
                        if (cr.Count == 0 || cr.Pop() != '(')
                        {
                            isBalanced = false;
                        }
                    }
                    else if (currChar == ']')
                    {
                        if (cr.Count == 0 || cr.Pop() != '[')
                        {
                            isBalanced = false;
                        }
                    }
                    else if (currChar == ' ')
                    {
                        if (cr.Count == 0 || cr.Pop() != ' ')
                        {
                            isBalanced = false;
                        }
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }
            if (isBalanced && cr.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
