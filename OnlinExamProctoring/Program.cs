using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace OnlinExamProctoring
{
    public class GradingSession : IDisposable
    {
        private StreamWriter resultsWriter;
        private StreamWriter flaggedWriter;
        private bool disposed = false;

        public GradingSession(string resultsFile, string flaggedFile)
        {
            resultsWriter = new StreamWriter(resultsFile);
            flaggedWriter = new StreamWriter(flaggedFile);
        }

        public void WriteResult(string message)
        {
            resultsWriter.WriteLine(message);
            resultsWriter.Flush();
        }

        public void WriteFlagged(string message)
        {
            flaggedWriter.WriteLine(message);
            flaggedWriter.Flush();
        }

        public void Dispose()
        {
            if (disposed)
                return;

            try
            {
                if (resultsWriter != null)
                {
                    resultsWriter.Flush();
                    resultsWriter.Close();
                }
            }
            catch
            {
            }

            try
            {
                if (flaggedWriter != null)
                {
                    flaggedWriter.Flush();
                    flaggedWriter.Close();
                }
            }
            catch
            {
            }

            disposed = true;
            GC.SuppressFinalize(this);
        }

        ~GradingSession()
        {
            Dispose();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Online Exam Proctoring & Grading Engine");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Enter number of submissions");
            int submissions = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of tab switches");
            int tabswitch = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter start time:");
            DateTime start = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter end time:");
            DateTime end = DateTime.Parse(Console.ReadLine());

            Submissions sub = new Submissions(
                submissions,
                tabswitch,
                true);

            sub.StudentId = 1;
            sub.StartTime = start;
            sub.EndTime = end;

            Console.WriteLine("Enter Question id");
            int questionId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter type of question");
            string type = Console.ReadLine();

            Console.WriteLine("Enter weight of each question");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Correct Answer");
            string correct = Console.ReadLine();

            Console.WriteLine("Enter negative marking");
            double negativeMarking = double.Parse(Console.ReadLine());

            Question q = new Question(
                questionId,
                type,
                weight,
                correct,
                negativeMarking);

            Console.WriteLine("Enter Student Answer");
            string studentAnswer = Console.ReadLine();

            sub.Answers.Add(
                new KeyValuePair<int, string>(
                    questionId,
                    studentAnswer));

            ExamGradingEngine engine =
                new ExamGradingEngine();

            engine.GradingCompleted +=
                (sender, e) =>
                Console.WriteLine("Grading Completed");

            engine.IntegrityViolationFlagged +=
                (sender, e) =>
                Console.WriteLine("Integrity Violation Flagged");

            List<Question> questions =
                new List<Question> { q };

            List<Submissions> submissionList =
                new List<Submissions> { sub };

            Console.WriteLine();
            Console.WriteLine("Processing Submission...");
            Console.WriteLine();

            engine.ProcessBatch(
                questions,
                submissionList);

            Console.WriteLine();
            Console.WriteLine("LINQ CLASS ANALYSIS");

            List<double> scores =
                new List<double> { 80, 90, 70 };

            Console.WriteLine(
                "Class Average: " +
                engine.CalculateAverageUsingLinq(scores));

            var distribution =
                engine.GetGradeDistribution(scores);

            Console.WriteLine("Grade Distribution:");

            foreach (var item in distribution)
            {
                Console.WriteLine(
                    item.Key + ": " + item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Reflection - Question Methods");

            Type questionType =
                typeof(Question);

            foreach (MethodInfo method in
                     questionType.GetMethods())
            {
                Console.WriteLine(method);
            }

            Console.WriteLine();
            Console.WriteLine(
                "Reflection - Submission Properties");

            Type submissionType =
                typeof(Submissions);

            foreach (PropertyInfo property in
                     submissionType.GetProperties())
            {
                Console.WriteLine(property);
            }

            Console.WriteLine();
            Console.WriteLine("Custom Attributes");

            Type engineType =
                typeof(ExamGradingEngine);

            MethodInfo processMethod =
                engineType.GetMethod(
                    "ProcessQuestion",
                    BindingFlags.Instance |
                    BindingFlags.Public |
                    BindingFlags.NonPublic);

            if (processMethod != null)
            {
                foreach (object attribute in
                         processMethod.GetCustomAttributes())
                {
                    Console.WriteLine(attribute);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Enter total students in class");

            int total =
                int.Parse(Console.ReadLine());

            try
            {
                engine.ComputingClassAverageScore(
                    total,
                    10000);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Grading Session");

            using (GradingSession session =
                   new GradingSession(
                       "results.txt",
                       "flagged.txt"))
            {
                session.WriteResult(
                    "Grading session completed.");

                session.WriteFlagged(
                    "Flagged submissions are recorded separately.");
            }

            Console.WriteLine();
            Console.WriteLine("Program completed.");
        }
    }
}
