using NUnit.Framework;
using System;

namespace OnlinExamProctoring.Tests
{
    public class UnitTest1
    {
        [Test]
        public void CreateScore_ReturnsCorrectScore()
        {
            Submissions submission =
                new Submissions(1, 0, false);

            var scoreRule =
                Submissions.CreateScore(0.2);

            double result = scoreRule(submission);

            Assert.That(result, Is.EqualTo(0.8));
        }

        [Test]
        public void IntegrityRule_ReturnsFalse_ForTooManyTabSwitches()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            Submissions submission =
                new Submissions(
                    1,
                    DateTime.Now.AddMinutes(-10),
                    DateTime.Now,
                    10);

            var rule =
                engine.CreateIntegrityRule(
                    TimeSpan.FromMinutes(5),
                    5);

            Assert.That(rule(submission), Is.False);
        }

        [Test]
        public void ComputingClassAverage_ReturnsCorrectAverage()
        {
            ExamGradingEngine engine =
                new ExamGradingEngine();

            int result =
                engine.ComputingClassAverageScore(10, 800);

            Assert.That(result, Is.EqualTo(80));
        }
    }
}
