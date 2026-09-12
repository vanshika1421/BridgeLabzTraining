using BirdSentury;

class Duck : Bird, IFlyable, ISwimable, IRunable
{
    public Duck(int id , Gender gender)
        : base( id ,gender)
    {
    }

    public void Fly()
    {
        Console.WriteLine("Duck is flying.");
    }

    public void swim()
    {
        Console.WriteLine("Duck is swimming.");
    }

    public void Run()
    {
        Console.WriteLine("Duck is running.");
    }

   
}
