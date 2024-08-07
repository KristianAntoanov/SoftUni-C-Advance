namespace ClimbthePeaks
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> portionsQuantity = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> staminaQuantity = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Dictionary<string, int> peaks = new()
            {
                { "Vihren", 80 },
                { "Kutelo", 90 },
                { "Banski Suhodol", 100 },
                { "Polezhan", 60 },
                { "Kamenitza", 70 },
            };
            Queue<string> peaksNames = new(new List<string> { "Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" });
            HashSet<string> conqueredPeaks = new HashSet<string>();

            while (portionsQuantity.Any() && staminaQuantity.Any() && peaksNames.Any())
            {
                int currPortions = portionsQuantity.Pop();
                int currStamina = staminaQuantity.Dequeue();
                if (currPortions + currStamina >= peaks[peaksNames.Peek()])
                {
                    conqueredPeaks.Add(peaksNames.Dequeue());
                }
            }
            if (conqueredPeaks.Count == 5)
            {
                Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }
            else
            {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }
            if (conqueredPeaks.Any())
            {
                Console.WriteLine($"Conquered peaks:");
                Console.WriteLine(String.Join(Environment.NewLine, conqueredPeaks));
            }
        }
    }
}
