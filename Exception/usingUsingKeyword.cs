//using System.Runtime.Intrinsics.X86;

//5.Using using Statement for File Handling
//💡 Problem Statement:
//Write a C# program that reads the first line of a file named "info.txt" using StreamReader.
//Use using to ensure the file is automatically closed after reading.
//Handle any IOException that may occur.
//Expected Behavior:
//If the file exists, print its first line.



using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class usingUsingKeyword
    {
        public void usingKey(String file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    String content = sr.ReadLine();
                    Console.WriteLine(content);
                }

            }
            catch(IOException ex)
            {
                    Console.WriteLine("Error Reading file");
            }

        }
    }
}
