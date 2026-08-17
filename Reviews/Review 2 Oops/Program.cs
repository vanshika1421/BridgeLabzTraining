using Review;
using static Review.KnockOut;

namespace TournamentManagementSystem;
internal class Program
{
    public static void Main()
    {
        
        Console.WriteLine("Enter Type of Match");
        string s = Console.ReadLine();
        
       
        if (s.Equals("KnockOut"))
        {
            Console.WriteLine("Enter Team A id");
            int TeamAId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Team B id");
            int TeamBId = int.Parse(Console.ReadLine());
            Matches k = new KnockOut(TeamAId , TeamBId);
            //Console.WriteLine(k.CanEndInDraw());
            
            Console.WriteLine("Enter score of team A");
            int scoreA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter score of team B");
            int scoreB = int.Parse(Console.ReadLine());
            Console.WriteLine(k.WinnerTeamId(scoreB , scoreA)+ "team is the winnder");

        }
        else if(s.Equals("League"))
        {
            Console.WriteLine("Enter Team A id");
            int TeamAId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Team B id");
            int TeamBId = int.Parse(Console.ReadLine());
            Matches l = new League(101 , 102);
            Console.WriteLine("Enter score of team A");
            int scoreA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter score of team B");
            int scoreB = int.Parse(Console.ReadLine());
            Console.WriteLine(l.WinnerTeamId(scoreA , scoreB)+ "team is the winner");
        }


    }
}