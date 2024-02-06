namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<PetrolPump> pumps = new Queue<PetrolPump>();

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(new PetrolPump(nums[0], nums[1]));
            }

            int count = -1;

            while (true)
            {
                count++;
                int currLiters = 0;
                bool isVallid = true;
                for (int i = 0; i < pumps.Count; i++)
                {
                    PetrolPump currPump = pumps.Dequeue();
                    currLiters += currPump.Liters;
                    currLiters -= currPump.Distance;

                    pumps.Enqueue(currPump);
                    if (currLiters < 0)
                    {
                        isVallid = false;
                    }
                }
                if (isVallid)
                {
                    break;
                }
                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(count);
        }
    }
    class PetrolPump
    {
        public PetrolPump(int liters, int distance)
        {
            Liters = liters;
            Distance = distance;
        }

        public int Liters { get; set; }
        public int Distance { get; set; }

    }
}
