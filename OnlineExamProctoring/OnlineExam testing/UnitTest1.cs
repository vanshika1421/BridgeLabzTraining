
using OnlinExamProctoring;
namespace OnlineExam_testing
{
    public class Tests
    {

        private ExamGradingEngine e;
        [SetUp]
        public void Setup()
        {
            e = new ExamGradingEngine();
        }

        [Test]
        public void TestingClassAvgScore()
        {
            int Total = 0;
            int res = 5000 / Total;

            Assert.Throws<DivideByZeroException>(() =>
            {
                
            });
        }
    }
}
