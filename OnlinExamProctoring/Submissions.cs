using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlinExamProctoring
{
    public class Submissions
    {
        public delegate Func<Submissions, double> CreateScoringRule(double negativeMarkingFactor);
        public delegate Action<Submissions> Logging(Submissions submission);

        public int StudentId { get; set; }
        public List<KeyValuePair<int, string>> Answers { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int NumberOfSubmissions { get; set; }
        public int NumberOfTabSwitches { get; set; }
        public bool ExcessiveFastScoring { get; set; }
        public double Score { get; set; }

        public Submissions(int numberOfSubmissions, int numberOfTabswitches, bool excessiveFastScoring)
        {
            NumberOfSubmissions = numberOfSubmissions;
            NumberOfTabSwitches = numberOfTabswitches;
            ExcessiveFastScoring = excessiveFastScoring;
            Answers = new List<KeyValuePair<int, string>>();
        }

        public Submissions(int studentId, DateTime startTime, DateTime endTime, int numberOfTabswitches)
        {
            StudentId = studentId;
            StartTime = startTime;
            EndTime = endTime;
            NumberOfTabSwitches = numberOfTabswitches;
            Answers = new List<KeyValuePair<int, string>>();
        }

        public static Func<Submissions, double> CreateScore(double negativeMarkingFactor)
        {
            return submission =>
            {
                double score = 1.0;

                if (submission.NumberOfTabSwitches > 3)
                    score -= 0.1 * submission.NumberOfTabSwitches;

                if (submission.ExcessiveFastScoring)
                    score -= 0.5;

                score -= negativeMarkingFactor;

                return Math.Max(0, score);
            };
        }

        public void CheckValidStudentId(List<int> studentIds, int studentId)
        {
            if (!studentIds.Contains(studentId))
                throw new InvalidSubmissionException(
                    studentId,
                    "Student ID not found.");
        }
    }
}