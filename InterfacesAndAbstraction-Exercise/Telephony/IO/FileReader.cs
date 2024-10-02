using System;
using System.Reflection.PortableExecutable;
using Telephony.IO.Interfaces;

namespace Telephony.IO
{
    public class FileReader : IReader
    {
        public string ReadLine()
        {
            string filePath = "../../../Input.txt";

            using StreamReader sr = new StreamReader(filePath);

            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine();
                return line;
            }
            return null;
        }
    }
}

