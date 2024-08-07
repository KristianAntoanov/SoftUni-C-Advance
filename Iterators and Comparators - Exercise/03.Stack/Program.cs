namespace Stack
{
    using System;
    using _03.Stack;

    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomStack<int> stack = new();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                //Push 1, 2, 3, 4
                string[] cmdArgs = command
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Push")
                {
                    int[] itemsToPush = cmdArgs
                        .Skip(1)
                        .Select(int.Parse)
                        .ToArray();
                    foreach (var item in itemsToPush)
                    {
                        stack.Push(item);
                    }
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}