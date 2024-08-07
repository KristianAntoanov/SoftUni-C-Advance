namespace ApocalypsePreparation
{
    using System;
    using System.Linq;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> textiles = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> medicaments = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, int> items = new Dictionary<string, int>();

            while (textiles.Any() && medicaments.Any())
            {
                int currSum = textiles.Peek() + medicaments.Peek();

                if (currSum == 30)
                {
                    if (!items.ContainsKey("Patch"))
                    {
                        items["Patch"] = 0;
                    }
                    items["Patch"]++;
                    textiles.Dequeue();
                    medicaments.Pop();
                }
                else if (currSum == 40)
                {
                    if (!items.ContainsKey("Bandage"))
                    {
                        items["Bandage"] = 0;
                    }
                    items["Bandage"]++;
                    textiles.Dequeue();
                    medicaments.Pop();
                }
                else if (currSum == 100)
                {
                    if (!items.ContainsKey("MedKit"))
                    {
                        items["MedKit"] = 0;
                    }
                    items["MedKit"]++;
                    textiles.Dequeue();
                    medicaments.Pop();
                }
                else if (currSum > 100)
                {
                    if (!items.ContainsKey("MedKit"))
                    {
                        items["MedKit"] = 0;
                    }
                    items["MedKit"]++;
                    textiles.Dequeue();
                    medicaments.Pop();
                    currSum -= 100;
                    int nextValueOfMedicaments = medicaments.Pop();
                    medicaments.Push(nextValueOfMedicaments + currSum);
                }
                else
                {
                    textiles.Dequeue();
                    int nextValueOfMedicaments = medicaments.Pop();
                    medicaments.Push(nextValueOfMedicaments + 10);
                }
            }
            if (!textiles.Any() && !medicaments.Any())
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }
            else if (!medicaments.Any())
            {
                Console.WriteLine("Medicaments are empty.");
            }
            else if (!textiles.Any())
            {
                Console.WriteLine("Textiles are empty.");
            }
            foreach (var item in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            if (medicaments.Any())
            {
                Console.WriteLine($"Medicaments left: {String.Join(", ", medicaments)}");
            }
            if (textiles.Any())
            {
                Console.WriteLine($"Textiles left: {String.Join(", ", textiles)}");
            }
        }
    }
}