namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"../../../text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            using StreamReader reader = new StreamReader(inputFilePath);

            string line = string.Empty;
            int count = 0;

            while (line != null)
            {
                line = reader.ReadLine();

                if (count % 2 == 0)
                {
                    string replacedSymbols = ReplacedSymbols(line);
                    string reversedWords = ReversedWords(replacedSymbols);
                    sb.Append(reversedWords);
                }
                count++;
            }

            return sb.ToString().TrimEnd();
        }

        private static string ReplacedSymbols(string line)
        {
            StringBuilder sb = new StringBuilder(line);

            char[] symbolsToReplace = { '-', ',', '.', '!', '?' };

            foreach (char cr in symbolsToReplace)
            {
                sb = sb.Replace(cr, '@');
            }

            return sb.ToString();
        }
        private static string ReversedWords(string words)
        {
            string[] reversedWords = words
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();
            return String.Join(" ", reversedWords);
        }

    }
}
