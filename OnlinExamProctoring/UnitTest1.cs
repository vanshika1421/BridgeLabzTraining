using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace OnlinExamProctoring.Tests
{
    [TestFixture]
    public class ExamGradingEngineTests
    {
        // 1. Normal submission grades correctly
        [Test]
        public void NormalSubmission_ShouldGradeCorrectly()
        {
            Question q = new Question(1, "MCQ", 2.0, "A", 0);

            Submissions sub =
                new Submissions(1, DateTime.Now.AddMinutes(-10),
                                DateTime.Now, 2);

            sub.Answers.Add(
                new KeyValuePair<int, string>(1, "A"));

            ExamGradingEngine engine =
                new ExamGradingEngine();

            double score =
                engine.GradeSubmission(
                    sub,
                    new List<Question> { q });

            Assert.That(score, Is.EqualTo(2.0));
        }

        // 2. Negative marking attribute
        [Test]
        public void NegativeMarking_ShouldReduceScore()
        {
            Question q =
                new Question(1, "MCQ", 2.0, "A", 0.25);

            Submissions sub =
                new Submissions(1, DateTime.Now.AddMinutes(-10),
                                DateTime.Now, 2);

            sub.Answers.Add(
                new KeyValuePair<int, string>(1, "B"));

            ExamGradingEngine engine =
                new ExamGradingEngine();

            double score =
                engine.GradeSubmission(
                    sub,
                    new List<Question> { q });

            Assert.That(score, Is.GreaterThanOrEqualTo(0));
        }

        // 3. Invalid Question ID
        [Test]
        public void InvalidQuestionId_ShouldThrowException()
        {
            Question q =
                new Question(1, "MCQ", 2.0, "A", 0);

            Submissions sub =
                new Submissions(1, DateTime.Now.AddMinutes(-10),
                                DateTime.Now, 2);

            sub.Answers.Add(
                new KeyValuePair<int, string>(99, "A"));

            ExamGradingEngine engine =
                new ExamGradingEngine();

            Assert.Throws<InvalidSubmissionException>(() =>
                engine.GradeSubmission(
                    sub,
                    new List<Question> { q }));
        }

        // 4. Integrity rule violation
        [Test]
        public void IntegrityRule_ShouldDetectViolation()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            Predicate<Submissions> rule =
                engine.CreateIntegrityRule(
                    TimeSpan.FromMinutes(5), 5);

            Submissions sub =
                new Submissions(
                    1,
                    DateTime.Now.AddMinutes(-2),
                    DateTime.Now,
                    10);

            Assert.That(rule(sub), Is.False);
        }

        // 5. Closure with different negative factors
        [Test]
        public void DifferentNegativeFactors_ShouldGiveDifferentScores()
        {
            Submissions sub =
                new Submissions(1, 1, false);

            Func<Submissions, double> rule1 =
                Submissions.CreateScore(0.1);

            Func<Submissions, double> rule2 =
                Submissions.CreateScore(0.5);

            double score1 = rule1(sub);
            double score2 = rule2(sub);

            Assert.That(score1, Is.Not.EqualTo(score2));
        }

        // 6. Both events can occur
        [Test]
        public void IntegrityViolation_And_GradingCompleted_CanBothOccur()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            bool integrityFlagged = false;
            bool gradingCompleted = false;

            engine.IntegrityViolationFlagged +=
                (sender, e) => integrityFlagged = true;

            engine.GradingCompleted +=
                (sender, e) => gradingCompleted = true;

            Question q =
                new Question(1, "MCQ", 2, "A", 0);

            Submissions sub =
                new Submissions(
                    1,
                    DateTime.Now.AddMinutes(-1),
                    DateTime.Now,
                    10);

            sub.Answers.Add(
                new KeyValuePair<int, string>(1, "A"));

            engine.ProcessBatch(
                new List<Question> { q },
                new List<Submissions> { sub });

            Assert.That(integrityFlagged, Is.True);
            Assert.That(gradingCompleted, Is.True);
        }

        // 7. LINQ grade distribution
        [Test]
        public void GradeDistribution_ShouldBeCorrect()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            List<Submissions> submissions =
                new List<Submissions>
                {
                    new Submissions(1, DateTime.Now, DateTime.Now, 0)
                    {
                        Score = 95
                    },
                    new Submissions(2, DateTime.Now, DateTime.Now, 0)
                    {
                        Score = 80
                    },
                    new Submissions(3, DateTime.Now, DateTime.Now, 0)
                    {
                        Score = 50
                    }
                };

            var result =
                engine.GetGradeDistribution(submissions);

            Assert.That(result["A"], Is.EqualTo(1));
            Assert.That(result["B"], Is.EqualTo(1));
            Assert.That(result["D"], Is.EqualTo(1));
        }

        // 8. LINQ class average
        [Test]
        public void ClassAverage_ShouldBeCalculatedUsingLinq()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            List<Submissions> submissions =
                new List<Submissions>
                {
                    new Submissions(1, DateTime.Now, DateTime.Now, 0)
                    {
                        Score = 80
                    },
                    new Submissions(2, DateTime.Now, DateTime.Now, 0)
                    {
                        Score = 90
                    },
                    new Submissions(3, DateTime.Now, DateTime.Now, 0)
                    {
                        Score = 70
                    }
                };

            double average =
                engine.CalculateAverageUsingLinq(
                    submissions);

            Assert.That(average, Is.EqualTo(80));
        }

        // 9. Lowest correct-answer rate
        [Test]
        public void LowestCorrectRateQuestion_ShouldBeIdentified()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            Question q1 =
                new Question(1, "MCQ", 2, "A", 0);

            Question q2 =
                new Question(2, "MCQ", 2, "B", 0);

            Submissions s1 =
                new Submissions(1, DateTime.Now,
                                DateTime.Now, 0);

            s1.Answers.Add(
                new KeyValuePair<int, string>(1, "A"));

            s1.Answers.Add(
                new KeyValuePair<int, string>(2, "A"));

            Submissions s2 =
                new Submissions(2, DateTime.Now,
                                DateTime.Now, 0);

            s2.Answers.Add(
                new KeyValuePair<int, string>(1, "A"));

            s2.Answers.Add(
                new KeyValuePair<int, string>(2, "A"));

            int result =
                engine.GetLowestCorrectRateQuestion(
                    new List<Question> { q1, q2 },
                    new List<Submissions> { s1, s2 });

            Assert.That(result, Is.EqualTo(2));
        }

        // 10. Zero submission guard
        [Test]
        public void ZeroSubmission_ShouldThrowDivideByZeroException()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            Assert.Throws<DivideByZeroException>(() =>
                engine.ComputingClassAverageScore(0, 100));
        }

        // 11. Score cannot become negative
        [Test]
        public void HeavyNegativeMarking_ShouldNotGiveNegativeScore()
        {
            Submissions sub =
                new Submissions(1, 20, true);

            Func<Submissions, double> rule =
                Submissions.CreateScore(5.0);

            double score = rule(sub);

            Assert.That(score, Is.GreaterThanOrEqualTo(0));
        }

        // 12. Batch continues after invalid submission
        [Test]
        public void Batch_ShouldContinueAfterInvalidSubmission()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            Question q =
                new Question(1, "MCQ", 2, "A", 0);

            Submissions invalid =
                new Submissions(
                    1,
                    DateTime.Now.AddMinutes(-10),
                    DateTime.Now,
                    0);

            invalid.Answers.Add(
                new KeyValuePair<int, string>(99, "A"));

            Submissions valid =
                new Submissions(
                    2,
                    DateTime.Now.AddMinutes(-10),
                    DateTime.Now,
                    0);

            valid.Answers.Add(
                new KeyValuePair<int, string>(1, "A"));

            engine.ProcessBatch(
                new List<Question> { q },
                new List<Submissions>
                {
                    invalid,
                    valid
                });

            Assert.That(valid.Score, Is.EqualTo(2));
        }

        // 13. Duplicate Student ID
        [Test]
        public void DuplicateStudentId_ShouldThrowException()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            Submissions s1 =
                new Submissions(
                    1,
                    DateTime.Now,
                    DateTime.Now,
                    0);

            Submissions s2 =
                new Submissions(
                    1,
                    DateTime.Now,
                    DateTime.Now,
                    0);

            Assert.Throws<InvalidOperationException>(() =>
                engine.ProcessBatch(
                    new List<Question>(),
                    new List<Submissions>
                    {
                        s1,
                        s2
                    }));
        }
    }
}