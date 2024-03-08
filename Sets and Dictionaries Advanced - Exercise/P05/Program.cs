namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> charCounter= new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!charCounter.ContainsKey(text[i]))
                {
                    charCounter[text[i]] = 0;
                }
                charCounter[text[i]]++;
            }

            foreach (var item in charCounter.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
