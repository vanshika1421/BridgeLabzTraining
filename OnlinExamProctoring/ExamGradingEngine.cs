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
    
    public void ProcessBatch(List<Question> questions, List<Submissions> submissions)
{
    foreach (var submission in submissions)
    {
        try
        {
            foreach (var question in questions)
            {
                if (!submission.Answers.Exists(x => x.Key == question.QuestionId))
                {
                    throw new InvalidSubmissionException(
                        submission.StudentId,
                        "Question ID not found.");
                }
            }

            Predicate<Submissions> integrityRule =
                CreateIntegrityRule(
                    TimeSpan.FromMinutes(5),
                    5);

            try
            {
                if (!integrityRule(submission))
                {
                    throw new IntegrityViolationException(
                        submission.StudentId,
                        "Suspicious submission detected.");
                }
            }
            catch (IntegrityViolationException ex)
            {
                Console.WriteLine(ex.Message);
                FlagIntegrityViolation();
            }

            Func<Submissions, double> scoringRule =
                Submissions.CreateScore(0.25);

            double score = scoringRule(submission);

            Console.WriteLine(
                $"Student {submission.StudentId} Score: {score}");

            CompleteGrading();
        }
        catch (InvalidSubmissionException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine(
                $"Finished processing Student {submission.StudentId}");
        }
    }
    }
}
}
