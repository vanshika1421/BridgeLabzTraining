using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OnlinExamProctoring
{
    public class ExamGradingEngine
    {
        public event EventHandler GradingCompleted;
        public event EventHandler IntegrityViolationFlagged;

        public Predicate<Submissions> CreateIntegrityRule(TimeSpan minPlausibleDuration, int maxTabSwitches)
        {
            return submission =>
                submission.EndTime - submission.StartTime >= minPlausibleDuration &&
                submission.NumberOfTabSwitches <= maxTabSwitches;
        }

        public int ComputingClassAverageScore(int total, int totalScore)
        {
            if (total == 0)
                throw new DivideByZeroException(
                    "Cannot calculate class average because there are zero valid submissions.");

            return totalScore / total;
        }

        [QuestionWeight(2.0)]
        [NegativeMarking(0.25)]
        public double ProcessQuestion(Question question, string studentAnswer)
        {
            double weight = question.Weight;
            double negativeMarking = question.NegativeMarking;

            MethodInfo method = typeof(ExamGradingEngine)
                .GetMethod(nameof(ProcessQuestion));

            QuestionWeightAttribute weightAttribute =
                method.GetCustomAttribute<QuestionWeightAttribute>();

            NegativeMarkingAttribute negativeAttribute =
                method.GetCustomAttribute<NegativeMarkingAttribute>();

            if (weightAttribute != null)
                weight *= weightAttribute.Weight;

            if (studentAnswer == question.CorrectAnswer)
                return weight;

            double penalty = negativeMarking;

            if (negativeAttribute != null)
                penalty *= negativeAttribute.Marks;

            return Math.Max(0, -penalty);
        }

        public double GradeSubmission(
            Submissions submission,
            List<Question> questions)
        {
            Predicate<Question> specialQuestion =
                question => question.NegativeMarking > 0;

            double totalScore = 0;

            foreach (var question in questions)
            {
                var answer = submission.Answers
                    .FirstOrDefault(x => x.Key == question.QuestionId);

                if (answer.Key != question.QuestionId)
                    throw new InvalidSubmissionException(
                        submission.StudentId,
                        $"Question ID {question.QuestionId} not found.");

                double score;

                if (specialQuestion(question))
                {
                    score = ProcessQuestion(
                        question,
                        answer.Value);
                }
                else
                {
                    score = answer.Value == question.CorrectAnswer
                        ? question.Weight
                        : 0;
                }

                totalScore += score;
            }

            return Math.Max(0, totalScore);
        }

        public void ProcessBatch(
            List<Question> questions,
            List<Submissions> submissions)
        {
            HashSet<int> studentIds = new HashSet<int>();

            foreach (var submission in submissions)
            {
                if (!studentIds.Add(submission.StudentId))
                    throw new InvalidOperationException(
                        $"Duplicate StudentId found: {submission.StudentId}");
            }

            Predicate<Submissions> integrityRule =
                CreateIntegrityRule(
                    TimeSpan.FromMinutes(5),
                    5);

            foreach (var submission in submissions)
            {
                try
                {
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
                        IntegrityViolationFlagged?.Invoke(
                            this,
                            EventArgs.Empty);
                    }

                    submission.Score =
                        GradeSubmission(
                            submission,
                            questions);

                    Console.WriteLine(
                        $"Student {submission.StudentId} Score: {submission.Score}");

                    GradingCompleted?.Invoke(
                        this,
                        EventArgs.Empty);
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

        public double CalculateAverageUsingLinq(
            List<Submissions> submissions)
        {
            var validScores = submissions
                .Where(x => x.Score >= 0)
                .Select(x => x.Score)
                .ToList();

            if (!validScores.Any())
                throw new DivideByZeroException(
                    "Cannot calculate class average because there are zero valid submissions.");

            return validScores.Average();
        }

        public Dictionary<string, int> GetGradeDistribution(
            List<Submissions> submissions)
        {
            return submissions
                .GroupBy(x =>
                    x.Score >= 90 ? "A" :
                    x.Score >= 75 ? "B" :
                    x.Score >= 60 ? "C" :
                    x.Score >= 40 ? "D" : "F")
                .ToDictionary(
                    x => x.Key,
                    x => x.Count());
        }

        public int GetLowestCorrectRateQuestion(
            List<Question> questions,
            List<Submissions> submissions)
        {
            var result = questions
                .Select(question => new
                {
                    QuestionId = question.QuestionId,
                    CorrectRate = submissions.Count == 0
                        ? 0
                        : submissions.Count(s =>
                            s.Answers.Any(a =>
                                a.Key == question.QuestionId &&
                                a.Value == question.CorrectAnswer))
                          / (double)submissions.Count
                })
                .OrderBy(x => x.CorrectRate)
                .FirstOrDefault();

            return result?.QuestionId ?? -1;
        }

        public void CompleteGrading()
        {
            GradingCompleted?.Invoke(
                this,
                EventArgs.Empty);
        }

        public void FlagIntegrityViolation()
        {
            IntegrityViolationFlagged?.Invoke(
                this,
                EventArgs.Empty);
        }
    }
}