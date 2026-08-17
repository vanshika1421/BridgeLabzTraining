class Program
{
    static void Main(string[] args)
    {
        FileProcessor processor = new FileProcessor();

        processor.CopyFile(
            "source.txt",
            "destination.txt"
        );
    }
}