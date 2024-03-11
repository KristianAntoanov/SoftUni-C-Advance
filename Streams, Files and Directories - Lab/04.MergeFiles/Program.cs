namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"../../../Files/input1.txt";
            var secondInputFilePath = @"../../../Files/input2.txt";
            var outputFilePath = @"../../../Files/output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<string> mergeFiles = new List<string>();
            using (StreamReader reader1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader reader2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        int count = 0;
                        while (!reader1.EndOfStream || !reader2.EndOfStream)
                        {
                            if (!reader1.EndOfStream)
                            {
                                string line = reader1.ReadLine();
                                writer.WriteLine(line);
                            }
                            if (!reader2.EndOfStream)
                            {
                                string line2 = reader2.ReadLine();
                                writer.WriteLine(line2);
                            }

                        }
                    }
                }
            }
        }
    }
}