using System;
namespace Sorting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortStudentMarks marks = new SortStudentMarks();
            SortEmployeeIds Ids = new SortEmployeeIds();
            SortExamScores Ids2 = new SortExamScores();
            Ids2.SelectionSort([4, 2, 3, 1]);
        }
    }
}