using System;
namespace Linear_Search;
public class Program
{
    public static void Main(String[] args)
    //{
    //    LinearSearch ls = new LinearSearch();
    //    ls.SearchFirstNegativeNumber([1, 2, 3, -2, 8, -9]);
    {
        //SearchForSpecificWord s = new SearchForSpecificWord();
        //String[] sentences = ["Hi hello", "How do uh do?" ,"What is up" , "Give me some water" , "is the door open?" ];
        //s.FindSentenceContainingWord("is", sentences);
        //FindarotationalPoint f = new FindarotationalPoint();
        //Console.Write(f.findSmallestElement([ 3, 4, 5, 6, 1, 2]));
        PeakElement p = new PeakElement();
        //p.FindPeakElement([1, 3, 5, 7, 9, 11, 10, 8, 6, 2]);
        p.FindPeakElement([1, 3, 5, 4, 2]);
    }
}