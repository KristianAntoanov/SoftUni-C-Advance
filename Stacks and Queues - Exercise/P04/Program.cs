namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] ordersInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> orders = new Queue<int>(ordersInfo);

            Console.WriteLine(orders.Max());

            while (orders.Any())
            {
                int currOrder = orders.Peek();
                if (quantity < currOrder)
                {
                    break;
                }
                else
                {
                    quantity -= currOrder;
                    orders.Dequeue();
                }
            }
            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
