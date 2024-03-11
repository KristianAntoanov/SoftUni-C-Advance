using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"../../../Files/words.txt";
            string textPath = @"../../../Files/text.txt";
            string outputPath = @"../../../Files/output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                string[] words = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                using(StreamReader readerFromText = new StreamReader(textFilePath))
                {
                    Dictionary<string, int> containsWords = new Dictionary<string, int>();
                    while (readerFromText.EndOfStream == false)
                    {
                        string text = readerFromText.ReadLine();
                        text = text.ToLower();
                        Regex regex = new Regex(@"\b\w+\b");
                        MatchCollection matches = regex.Matches(text);
                        for (int i = 0; i < words.Length; i++)
                        {
                            foreach (var item in matches)
                            {
                                if (words[i] == item.ToString())
                                {
                                    if (!containsWords.ContainsKey(words[i]))
                                    {
                                        containsWords[words[i]] = 0;
                                    }
                                    containsWords[words[i]]++;
                                }
                            }
                        }
                    }
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        foreach (var item in containsWords.OrderByDescending(x => x.Value))
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}