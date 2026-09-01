using System;
using System.Reflection;

namespace OnlinExamProctoring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of submissions");
            int submissions = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of tab switches");
            int tabswitch = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter start time:");
            DateTime start = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter end time:");
            DateTime end = DateTime.Parse(Console.ReadLine());

            TimeSpan duration = end - start;

            Submissions sub = new Submissions(
                submissions,
                tabswitch,
                true
            );

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
                negativeMarking
            );

            Submissions.CreateScoringRule score =
                Submissions.CreateScore;

            Func<Submissions, double> result =
                score(1.0);

            Console.WriteLine(result(sub));

            Type typee = typeof(Question);

            MethodInfo[] m = typee.GetMethods();

            foreach (MethodInfo mm in m)
            {
                Console.WriteLine(mm);
            }

            Console.WriteLine("Enter total students in class");
            int total = int.Parse(Console.ReadLine());

            ExamGradingEngine e = new ExamGradingEngine();

            int totalScore = 10000;

            e.ComputingClassAverageScore(
                total,
                totalScore
            );

            Type type2 = typeof(Submissions);

            MethodInfo[] m2 = type2.GetMethods();

            foreach (MethodInfo m3 in m2)
            {
                Console.WriteLine(m3);
            }

            Console.WriteLine("Properties using reflection");

            PropertyInfo[] p = type2.GetProperties();

            foreach (PropertyInfo p3 in p)
            {
                Console.WriteLine(p3);
            }

            Console.WriteLine("Get custom Attributes");

            var attributes = type2.GetCustomAttributes();

            foreach (var attr in attributes)
            {
                Console.WriteLine(attr);
            }
        }
    }
}