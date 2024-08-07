namespace P01
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> money = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> prices = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int ateFoods = 0;
            while (money.Any() && prices.Any())
            {
                if (money.Peek() == prices.Peek())
                {
                    money.Pop();
                    prices.Dequeue();
                    ateFoods++;
                }
                else if (money.Peek() > prices.Peek())
                {
                    int currPrice = prices.Dequeue();
                    int currMoney = money.Pop();
                    int nextMoney = 0;
                    if (money.Any())
                    {
                        nextMoney = money.Pop();
                    }
                    money.Push(nextMoney + currMoney - currPrice);
                    ateFoods++;
                }
                else if (money.Peek() < prices.Peek())
                {
                    money.Pop();
                    prices.Dequeue();
                }
            }
            if (ateFoods >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {ateFoods} foods.");
            }
            else if (ateFoods < 4 && ateFoods > 1)
            {
                Console.WriteLine($"Henry ate: {ateFoods} foods.");
            }
            else if (ateFoods == 1)
            {
                Console.WriteLine($"Henry ate: {ateFoods} food.");
            }
            else
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}