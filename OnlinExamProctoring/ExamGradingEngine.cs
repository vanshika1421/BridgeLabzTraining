using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OnlinExamProctoring
{
    public class ExamGradingEngine
    {
        // =========================================================
        // EVENTS
        // =========================================================

        public event EventHandler GradingCompleted;
        public event EventHandler IntegrityViolationFlagged;


        // =========================================================
        // INTEGRITY RULE
        // =========================================================

        public Predicate<Submissions> CreateIntegrityRule(
            TimeSpan minPlausibleDuration,
            int maxTabSwitches)
        {
            return submission =>
                submission.EndTime - submission.StartTime >=
                    minPlausibleDuration
                &&
                submission.NumberOfTabSwitches <= maxTabSwitches;
        }


        // =========================================================
        // CLASS AVERAGE - NORMAL METHOD
        // =========================================================

        public int ComputingClassAverageScore(
            int total,
            int totalScore)
        {
            if (total == 0)
            {
                throw new DivideByZeroException(
                    "Cannot calculate class average because there are zero valid submissions.");
            }

            return totalScore / total;
        }


        // =========================================================
        // PROCESS QUESTION
        // CUSTOM ATTRIBUTES + REFLECTION
        // =========================================================

        [QuestionWeight(2.0)]
        [NegativeMarking(0.25)]
        public double ProcessQuestion(
            Question question,
            string studentAnswer)
        {
            double weight = question.Weight;
            double penalty = question.NegativeMarking;

            // Get the ProcessQuestion method using Reflection
            MethodInfo method =
                typeof(ExamGradingEngine).GetMethod(
                    nameof(ProcessQuestion));

            // Read QuestionWeight attribute
            QuestionWeightAttribute weightAttribute =
                method.GetCustomAttribute<QuestionWeightAttribute>();

            // Read NegativeMarking attribute
            NegativeMarkingAttribute negativeAttribute =
                method.GetCustomAttribute<NegativeMarkingAttribute>();


            // Apply QuestionWeight attribute
            if (weightAttribute != null)
            {
                weight *= weightAttribute.Weight;
            }


            // Correct answer
            if (studentAnswer == question.CorrectAnswer)
            {
                return weight;
            }


            // Wrong answer
            if (negativeAttribute != null)
            {
                penalty *= negativeAttribute.Marks;
            }

            // Negative marking
            return -penalty;
        }


        // =========================================================
        // GRADE ONE SUBMISSION
        // =========================================================

        public double GradeSubmission(
            Submissions submission,
            List<Question> questions)
        {
            // Predicate<Question>
            // Identifies questions requiring special handling
            Predicate<Question> specialQuestion =
                question => question.NegativeMarking > 0;

            double totalScore = 0;


            foreach (Question question in questions)
            {
                // Find answer using LINQ
                var answer =
                    submission.Answers.FirstOrDefault(
                        x => x.Key == question.QuestionId);


                // Question ID does not exist in submission
                if (answer.Key != question.QuestionId)
                {
                    throw new InvalidSubmissionException(
                        submission.StudentId,
                        $"Question ID {question.QuestionId} not found.");
                }


                double questionScore;


                // Question requiring negative marking
                if (specialQuestion(question))
                {
                    questionScore =
                        ProcessQuestion(
                            question,
                            answer.Value);
                }
                else
                {
                    // Lambda expression for normal scoring
                    questionScore =
                        answer.Value == question.CorrectAnswer
                            ? question.Weight
                            : 0;
                }


                totalScore += questionScore;
            }


            // Score must never go below zero
            return Math.Max(0, totalScore);
        }


        // =========================================================
        // PROCESS COMPLETE BATCH
        // =========================================================

        public void ProcessBatch(
            List<Question> questions,
            List<Submissions> submissions)
        {
            // Keep the existing 2-parameter method usable.
            // GradingSession is created for the complete batch.

            using (GradingSession session =
                   new GradingSession(
                       "results.txt",
                       "flagged.txt"))
            {
                ProcessBatch(
                    questions,
                    submissions,
                    session);
            }
        }


        // =========================================================
        // PROCESS BATCH WITH GRADING SESSION
        // =========================================================

        public void ProcessBatch(
            List<Question> questions,
            List<Submissions> submissions,
            GradingSession session)
        {
            // =====================================================
            // DUPLICATE STUDENT ID VALIDATION
            // =====================================================

            HashSet<int> studentIds =
                new HashSet<int>();

            foreach (Submissions submission in submissions)
            {
                if (!studentIds.Add(submission.StudentId))
                {
                    throw new InvalidOperationException(
                        $"Duplicate StudentId found: {submission.StudentId}");
                }
            }


            // =====================================================
            // CREATE INTEGRITY RULE
            // =====================================================

            Predicate<Submissions> integrityRule =
                CreateIntegrityRule(
                    TimeSpan.FromMinutes(5),
                    5);


            // =====================================================
            // ACTION<Submission> FOR LOGGING
            // =====================================================

            Action<Submissions> logSubmission =
                submission =>
                {
                    Console.WriteLine(
                        $"Logging Student {submission.StudentId}");
                };


            // =====================================================
            // PROCESS EACH SUBMISSION
            // =====================================================

            foreach (Submissions submission in submissions)
            {
                bool integrityViolation = false;

                try
                {
                    // ---------------------------------------------
                    // LOG SUBMISSION
                    // ---------------------------------------------

                    logSubmission(submission);


                    // ---------------------------------------------
                    // INTEGRITY CHECK
                    // ---------------------------------------------

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
                        // Integrity violation is NOT fatal.
                        // The submission will still be graded.

                        integrityViolation = true;

                        Console.WriteLine(ex.Message);

                        session.WriteFlagged(
                            ex.Message);

                        FlagIntegrityViolation();
                    }


                    // ---------------------------------------------
                    // GRADE SUBMISSION
                    // ---------------------------------------------

                    submission.Score =
                        GradeSubmission(
                            submission,
                            questions);


                    Console.WriteLine(
                        $"Student {submission.StudentId} Score: {submission.Score}");


                    // ---------------------------------------------
                    // WRITE NORMAL RESULT
                    // ---------------------------------------------

                    session.WriteResult(
                        $"Student {submission.StudentId} Score: {submission.Score}");


                    // ---------------------------------------------
                    // GRADING COMPLETED
                    // ---------------------------------------------

                    CompleteGrading();
                }
                catch (InvalidSubmissionException ex)
                {
                    Console.WriteLine(ex.Message);

                    session.WriteFlagged(
                        ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    session.WriteFlagged(
                        $"Unexpected error for Student {submission.StudentId}: {ex.Message}");
                }
                finally
                {
                    // ---------------------------------------------
                    // FINALLY
                    // ---------------------------------------------

                    Console.WriteLine(
                        $"Finished processing Student {submission.StudentId}");

                    // Flush both resources after every submission.
                    // Batch continues even if one submission fails.

                    try
                    {
                        session.FlushResults();
                    }
                    catch
                    {
                        // Defensive handling
                    }

                    try
                    {
                        session.FlushFlagged();
                    }
                    catch
                    {
                        // Defensive handling
                    }
                }
            }
        }


        // =========================================================
        // LINQ - CLASS AVERAGE
        // =========================================================

        public double CalculateAverageUsingLinq(
            List<Submissions> submissions)
        {
            var validScores =
                submissions
                    .Where(x => x.Score >= 0)
                    .Select(x => x.Score)
                    .ToList();


            if (!validScores.Any())
            {
                throw new DivideByZeroException(
                    "Cannot calculate class average because there are zero valid submissions.");
            }


            return validScores.Average();
        }


        // =========================================================
        // LINQ - GRADE DISTRIBUTION
        // =========================================================

        public Dictionary<string, int> GetGradeDistribution(
            List<Submissions> submissions)
        {
            return submissions
                .GroupBy(x =>
                    x.Score >= 90 ? "A" :
                    x.Score >= 75 ? "B" :
                    x.Score >= 60 ? "C" :
                    x.Score >= 40 ? "D" :
                    "F")
                .ToDictionary(
                    x => x.Key,
                    x => x.Count());
        }


        // =========================================================
        // LINQ - LOWEST CORRECT ANSWER RATE
        // =========================================================

        public int GetLowestCorrectRateQuestion(
            List<Question> questions,
            List<Submissions> submissions)
        {
            if (questions.Count == 0)
            {
                return -1;
            }


            var result =
                questions
                    .Select(question => new
                    {
                        QuestionId = question.QuestionId,

                        CorrectRate =
                            submissions.Count == 0
                                ? 0
                                : submissions.Count(
                                    submission =>
                                        submission.Answers.Any(
                                            answer =>
                                                answer.Key ==
                                                    question.QuestionId
                                                &&
                                                answer.Value ==
                                                    question.CorrectAnswer))
                                  / (double)submissions.Count
                    })
                    .OrderBy(x => x.CorrectRate)
                    .First();


            return result.QuestionId;
        }


        // =========================================================
        // EVENTS
        // =========================================================

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