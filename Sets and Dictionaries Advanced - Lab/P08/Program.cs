namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> reservationNumbers = new HashSet<string>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                if (!reservationNumbers.Contains(input) && input != "PARTY")
                {
                    reservationNumbers.Add(input);
                }
                else
                {
                    reservationNumbers.Remove(input);
                }
            }
            Console.WriteLine(reservationNumbers.Count);
            //reservationNumbers.OrderBy(str => !char.IsDigit(str.FirstOrDefault()));
            foreach (var item in reservationNumbers)
            {
                char[] cr = item.ToCharArray();
                if (char.IsDigit(cr[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in reservationNumbers)
            {
                char[] cr = item.ToCharArray();
                if (!char.IsDigit(cr[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
