namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songsToAppend = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> songs = new Queue<string>(songsToAppend);

            while (songs.Count > 0)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split()
                    .ToArray();
                if (cmdArgs[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (cmdArgs[0] == "Add")
                {
                    string[] remainingArgs = cmdArgs.Skip(1).ToArray();
                    string songToAdd = string.Join(" ", remainingArgs);

                    if (songs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songToAdd);
                    }
                }
                else if (cmdArgs[0] == "Show")
                {
                    Console.WriteLine($"{String.Join(", ", songs)}");
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
