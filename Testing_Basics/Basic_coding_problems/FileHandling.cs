using System.IO;
using System.Collections.Generic;
using System.Text;
//8.Testing File Handling Methods
//Problem:
//Create a class FileProcessor with the following methods:
//WriteToFile(string filename, string content): Writes content to a file.
//ReadFromFile(string filename): Reads content from a file.
//Write unit tests to check if:
//✅ The content is written and read correctly.
//✅ The file exists after writing.
//✅ Handling of IOException when the file does not exist.

namespace Unit_testing_examples
{
    public class FileHandling
    {

        public void WriteToFile(string file , string content)
        {
            File.WriteAllText(file, content);
        }
        public string readFromFile(string file)
        {
            if (!File.Exists(file))
            {
                throw new IOException("File not exists");
            }
            return File.ReadAllText(file);
        }

    }
}
