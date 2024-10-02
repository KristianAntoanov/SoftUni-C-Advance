using System;
using Telephony.IO.Interfaces;

namespace Telephony.IO
{
    public class FileWriter : IWriter
    {
        public void WriteLine(string line)
        {
            string filePath = "../../../text.txt";

            using StreamWriter sw = new StreamWriter(filePath, true);

            sw.WriteLine(line);
        }
    }
}

