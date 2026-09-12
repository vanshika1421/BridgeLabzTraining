//Console.WriteLine("Hello, World!");
/*
 * Parent classs abstract Bird
 * child diffrent type
 * properties of bird include name, age , species, 
 * methods in bird class AddBirds() , removebirds() , countbirds() , displaybird detials()
 * interfcase ifly , iswim , irun
 
 * */
using BirdSentury;

class Program
{
    static void Main()
    {
        Sentury sanctuary = new Sentury();
        Bird duck = new Duck(1, Gender.FEMALE)
        {
            Name = "Donald duck",
            species ="Duck"
        
        };
        Bird duck1 = new Duck(2, Gender.FEMALE)
        {
            Name = "Donald duck2",
            species ="Duck"
        
        };
         sanctuary.AddBird(duck);
      sanctuary.AddBird(duck1);
        HashSet<Bird> set = new HashSet<Bird>();
        foreach (Bird bird in set)
        {
            Console.WriteLine(bird.Name);
            Console.WriteLine(bird.Id);

        }
        sanctuary.CountBirds("Duck");
       
    }
}
