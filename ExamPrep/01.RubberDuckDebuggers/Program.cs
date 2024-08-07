namespace RubberDuckDebuggers
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> timeForOneTask = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> numberOfTasks = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int DarthVaderDucky = 0;
            int ThorDucky = 0;
            int BigBlueRubberDucky = 0;
            int SmallYellowRubberDucky = 0;

            while (timeForOneTask.Any() && numberOfTasks.Any())
            {
                int currTime = timeForOneTask.Peek();
                int currTasks = numberOfTasks.Peek();

                if (currTasks * currTime <= 60)
                {
                    timeForOneTask.Dequeue();
                    numberOfTasks.Pop();
                    DarthVaderDucky++;
                }
                else if (currTasks * currTime > 60 && currTasks * currTime <= 120)
                {
                    timeForOneTask.Dequeue();
                    numberOfTasks.Pop();
                    ThorDucky++;
                }
                else if (currTasks * currTime > 120 && currTasks * currTime <= 180)
                {
                    timeForOneTask.Dequeue();
                    numberOfTasks.Pop();
                    BigBlueRubberDucky++;
                }
                else if (currTasks * currTime > 180 && currTasks * currTime <= 240)
                {
                    timeForOneTask.Dequeue();
                    numberOfTasks.Pop();
                    SmallYellowRubberDucky++;
                }
                else if (currTasks * currTime > 240)
                {
                    timeForOneTask.Dequeue();
                    timeForOneTask.Enqueue(currTime);
                    currTasks -= 2;
                    numberOfTasks.Pop();
                    numberOfTasks.Push(currTasks);
                }
            }
            Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
            Console.WriteLine($"Darth Vader Ducky: {DarthVaderDucky}");
            Console.WriteLine($"Thor Ducky: {ThorDucky}");
            Console.WriteLine($"Big Blue Rubber Ducky: {BigBlueRubberDucky}");
            Console.WriteLine($"Small Yellow Rubber Ducky: {SmallYellowRubberDucky}");
        }
    }
}