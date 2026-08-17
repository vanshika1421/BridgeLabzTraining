//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Review
//{
//    public class KnockOut : Matches
//    {
//        public KnockOut(int teamAId, int teamBId)
//        {
//            TeamAId = teamAId;
//            TeamBId = teamBId;
//        }
//        public override bool CanEndInDraw()
//        {
//            return false;
//        }
//        public override int WinnerTeamId(int scoreB, int scoreA)
//        {
//            if (scoreA == scoreB)
//            {
//                Console.WriteLine("Its a draw but cant end the match continue playing");
//                return -1;
//            }
//            else if (scoreA > scoreB)
//            {
//                return TeamAId;
//            }

//            else
//            {
//                return TeamBId;
//            }

//        }
//    }
//}
