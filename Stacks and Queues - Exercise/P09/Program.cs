namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            Stack<string> memory = new Stack<string>();
            memory.Push(string.Empty);
             
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split();
                string cmdType = cmdArgs[0];

                if (cmdType == "1")
                {
                    string cmdValue = cmdArgs[1];
                    text.Append(cmdValue);
                    memory.Push(text.ToString());
                }
                else if (cmdType == "2")
                {
                    int crToRemove = int.Parse(cmdArgs[1]);
                    text = text.Remove(text.Length - crToRemove, crToRemove);
                    memory.Push(text.ToString());
                }
                else if (cmdType == "3")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index <= text.Length)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }
                else if (cmdType == "4")
                {
                    memory.Pop();
                    string previousVersion = memory.Peek();

                    text = new StringBuilder(previousVersion);
                }
            }
        }
    }
}
