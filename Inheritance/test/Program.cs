namespace test
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine()); // only price need to be double 
            double numberOfPuzzles = double.Parse(Console.ReadLine()); // int.
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            double numberOfBears = double.Parse(Console.ReadLine()); //  int.
            double numberOfMinions = double.Parse(Console.ReadLine()); //  int.
            int numberOfTrucks = int.Parse(Console.ReadLine()); 

            double ttlToys = numberOfPuzzles * 2.60 + numberOfTalkingDolls * 3.0 + numberOfBears * 4.1 + numberOfMinions * 8.2 + numberOfTrucks * 2;
            // without brackets 
            double ttlNumberOfToys = numberOfPuzzles + numberOfTalkingDolls + numberOfBears + numberOfMinions + numberOfTrucks;
            double ttlToys1 = 0;

            if (ttlNumberOfToys > 50)
            {
                ttlToys1 = ttlToys - (ttlToys * 0.25);
            }
            else
            {
                ttlToys1 = ttlToys;
            }

            double rent = ttlToys1 * 0.1;
            double ttlMoney = ttlToys1 - rent;

            if (ttlMoney > price)
            {
                Console.WriteLine($"{"Yes!"} {ttlMoney - price:f2} {"lv left."}");
            }
            else
            {
                Console.WriteLine($"{"Not enough money!"} {Math.Abs(ttlMoney - price):f2} {"lv needed."}");
            }
        }
    }
}