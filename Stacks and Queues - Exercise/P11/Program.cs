namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locksInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int reward = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksInfo);
            Stack<int> bullets = new Stack<int>(bulletsInfo);

            int bulletsShot = 0;
            while (locks.Count > 0 && bullets.Count > 0)
            {
                StartShootingLocks(barrelSize, locks, bullets,ref bulletsShot);
            }
            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int earnedMoney = reward - bulletsShot * bulletPrice;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }
        }

        static void StartShootingLocks(int barrelSize, Queue<int> locks, Stack<int> bullets, ref int bulletsShot)
        {
            int bulletSize = bullets.Pop();
            int lockSize = locks.Peek();
            bulletsShot++;
            if (bulletSize <= lockSize)
            {
                locks.Dequeue();
                Console.WriteLine("Bang!");
            }
            else
            {
                Console.WriteLine("Ping!");
            }
            if (bulletsShot % barrelSize == 0 && bullets.Any())
            {
                Console.WriteLine("Reloading!");
            }
        }
    }
}
