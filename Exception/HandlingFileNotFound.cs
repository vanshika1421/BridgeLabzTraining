using System;
using System.IO;

namespace Exception
{
    internal class HandlingFileNotFound
    {
        public void Read(string filename)
        {
            try
            {
                string content = File.ReadAllText(filename);
                Console.WriteLine(content);
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}