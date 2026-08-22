class Test
{
    [LogExecutionTime]
    public void Method1()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Method1 Executed");
    }

    [LogExecutionTime]
    public void Method2()
    {
        Thread.Sleep(500);
        Console.WriteLine("Method2 Executed");
    }
}