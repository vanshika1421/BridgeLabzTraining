using System;

namespace OnlinExamProctoring
{
    public class ExamGradingEngine
    {
        public event EventHandler GradingCompleted;
        public event EventHandler IntegrityViolationFlagged;

        public Predicate<Submissions> CreateIntegrityRule(TimeSpan minPlausibleDuration, int maxTabSwitches) { return submission => submission.EndTime - submission.StartTime >= minPlausibleDuration && submission.NumberOfTabSwitches <= maxTabSwitches; }

        public int ComputingClassAverageScore(int total, int totalScore) { if (total == 0) throw new DivideByZeroException("Cannot calculate class average because there are zero valid submissions."); int avg = totalScore / total; Console.WriteLine(avg); return avg; }

        public void CompleteGrading() { GradingCompleted?.Invoke(this, EventArgs.Empty); }

        public void FlagIntegrityViolation() { IntegrityViolationFlagged?.Invoke(this, EventArgs.Empty); }
    }
}