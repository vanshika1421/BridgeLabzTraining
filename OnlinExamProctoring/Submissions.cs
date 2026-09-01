using OnlinExamProctoring.OnlinExamProctoring;
using System;
using System.Collections.Generic;

namespace OnlinExamProctoring
{
    public class Submissions
    {
        public delegate Func<Submissions, double> CreateScoringRule(double negativeMarkingFactor);
        public delegate Action<Submissions> logging(Submissions submissions);

        public int StudentId { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }
        public int NumberOfSubmissions { get; set; }
        public int NumberOfTabSwitches { get; set; }
        public bool ExcessiveFastScoring { get; set; }

        public Submissions(int numberOfSubmissions, int numberOfTabswitches, bool excessiveFastScoring) { NumberOfSubmissions = numberOfSubmissions; NumberOfTabSwitches = numberOfTabswitches; ExcessiveFastScoring = excessiveFastScoring; }

        public Submissions(int studentId, DateTime startTime, DateTime endTime, int numberOfTabswitches) { StudentId = studentId; StartTime = startTime; EndTime = endTime; NumberOfTabSwitches = numberOfTabswitches; }

        public static Func<Submissions, double> CreateScore(double negativeMarkingFactor) { return x => { double score = 1.0; if (x.NumberOfTabSwitches > 3) score -= 0.1 * x.NumberOfTabSwitches; if (x.ExcessiveFastScoring) score -= 0.5; score -= negativeMarkingFactor; return Math.Max(0.0, score); }; }

        public void checkValidStudentId(List<int> studentIds, int studentId) { if (!studentIds.Contains(studentId)) throw new InvalidSubmissionException(studentId, "Student ID not found."); }
    }
}