using System;
using System.IO;

public class FileProcessor
{
    public void CopyFile(string sourceFile, string destinationFile)
    {
        try
        {
            using (FileStream sourceStream = new FileStream(
                sourceFile,
                FileMode.Open,
                FileAccess.Read))
            {
                using (FileStream destinationStream = new FileStream(
                    destinationFile,
                    FileMode.Create,
                    FileAccess.Write))
                {
                    int data;

                    while ((data = sourceStream.ReadByte()) != -1)
                    {
                        destinationStream.WriteByte((byte)data);
                    }
                }

            }

            Console.WriteLine("File copied successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Source file does not exist.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}