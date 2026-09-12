using BirdSentury;

class Duck : Bird, IFlyable, ISwimable, IRunable
{
    public Duck(string name, int age ,string species , int id , Gender gender)
        : base(name, age, "Duck" , id ,gender)
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