namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string currCarNumber = cmdArgs[1];
                if (command == "IN")
                {
                    carNumbers.Add(currCarNumber);
                }
                else if (command == "OUT")
                {
                    carNumbers.Remove(currCarNumber);
                }
            }
            if (carNumbers.Count > 0)
            {
                foreach (var item in carNumbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
