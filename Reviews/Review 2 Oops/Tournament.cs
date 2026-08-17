using System;
using System.Collections.Generic;
using System.Text;

namespace Review;
public abstract class Tournament
{
    public int TournamentId { get; set;
    }
    public string TournamentName { get; set; }
    const int numberOfMatches = 4;
   
  }
    public abstract class Matches : Tournament
    {
  

    public int MatchId { get; set; }
        public string MatchType { get; set; } = string.Empty;

        public abstract bool CanEndInDraw();
        public abstract int WinnerTeamId(int a , int b);
      

    }
    public class KnockOut : Matches
    {
        public int MatchID { get; set; }
    
        //public int scoreA { get; set; }
        //public int scoreB { get; set; }
        public int TeamAId;
        public int TeamBId;
  


    public KnockOut(int teamAId, int teamBId)
    {
        TeamAId = teamAId;
        TeamBId = teamBId;
    }
    public override bool CanEndInDraw()
        {
            return false;
        }
        public override int WinnerTeamId(int scoreB  , int scoreA)
        {
            if (scoreA == scoreB)
            {
                Console.WriteLine("Its a draw but cant end the match continue playing");
                return -1;
            }
            else if (scoreA > scoreB)
            {
                return TeamAId;
            }

            else
            {
                return TeamBId;
            }

        }
        public class League : Matches
        {
            public int TeamAId { get; set; }
            public int TeamBId { get; set; }
        public League(int teamAId, int teamBId)
        {
            TeamAId = teamAId;
            TeamBId = teamBId;
        }
            //public int scoreA { get; set;  }
            //public int scoreB { get; set; }
            public override int WinnerTeamId(int scoreB , int scoreA)
            {
                if (scoreB == scoreA)
                {
                    Console.WriteLine("Game ended with a draw");
                    return 0;
                }
                else if (scoreA > scoreB)
                {
                    return TeamAId;
                }
                else
                {
                    return TeamBId;
                }
            }

            public override bool CanEndInDraw()
            {
                return true;

            }

        }
  
}

