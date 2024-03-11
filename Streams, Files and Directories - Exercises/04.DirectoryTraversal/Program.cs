namespace DirectoryTraversal
{
    using System;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = "../../../../04.DirectoryTraversal";   
            string reportFileName = @"/report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionsFiles = new SortedDictionary<string, List<FileInfo>>();

            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!extensionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionsFiles[fileInfo.Extension] = new List<FileInfo>();
                }
                extensionsFiles[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var extensions in extensionsFiles.OrderByDescending(x => x.Value.Count))
            {
                sb.AppendLine(extensions.Key);

                foreach (var item in extensions.Value.OrderBy(x => x.Length))
                {
                    sb.AppendLine($"--{item.Name} - {(double)item.Length / 1024:f3}kb");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + reportFileName;

            File.WriteAllText(filePath, textContent);
        }
    }
}