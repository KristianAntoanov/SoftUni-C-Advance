namespace MonsterExtermination
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> armor = new Queue<int>(Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> striking = new Stack<int>(Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int killedMonsters = 0;

            while (armor.Any() && striking.Any())
            {
                if (striking.Peek() >= armor.Peek())
                {
                    int remainingValueOfStrike = striking.Pop() - armor.Dequeue();

                    if (striking.Any() && remainingValueOfStrike > 0)
                    {
                        int currValue = striking.Pop();
                        striking.Push(currValue + remainingValueOfStrike);
                    }
                    if (!striking.Any() && remainingValueOfStrike > 0)
                    {
                        striking.Push(remainingValueOfStrike);
                    }
                    killedMonsters++;
                }
                else
                {
                    int currStrike = striking.Pop();
                    int currArmor = armor.Dequeue();
                    armor.Enqueue(currArmor - currStrike);
                }
            }
            if (!armor.Any())
            {
                Console.WriteLine("All monsters have been killed!");
            }
            if (!striking.Any())
            {
                Console.WriteLine("The soldier has been defeated.");
            }
            Console.WriteLine($"Total monsters killed: {killedMonsters}");
        }
    }
}
