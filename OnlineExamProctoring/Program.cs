//using System.Runtime.Intrinsics.X86;

//Problem — Online Exam Proctoring & Grading Engine
//Scenario:
//An online assessment platform needs to grade submitted exams using configurable, question - type - specific scoring rules,
//detect potential integrity violations (e.g., suspiciously fast completion, excessive tab-switch events) via composable rules,
//and notify instructors of flagged submissions separately from normal grade-ready notifications. Question types carry metadata
//describing scoring weight and negative marking. A grading session manages a results-export resource and a flagged-submission
//log, both needing correct disposal across a full class batch.

//Objective:
//Build an ExamGradingEngine that scores Submission objects using configurable rules, detects integrity anomalies, raises differentiated events, and exports results.

//Functional Requirements:
//Model Submission(StudentId, Answers list, StartTime, EndTime, TabSwitchCount) and Question(QuestionId, Type, Weight, CorrectAnswer, NegativeMarking).
//Build scoring/rule delegates via closures: CreateScoringRule(double negativeMarkingFactor) returning a Func<Submission, double>, and CreateIntegrityRule(TimeSpan minPlausibleDuration, int maxTabSwitches) returning a Predicate<Submission>.
//Raise two independent events: GradingCompleted and IntegrityViolationFlagged; separate subscriber lists (gradebook publisher vs. academic-integrity queue).
//Use Predicate<Question> to filter question types requiring special handling (e.g., negative marking) and Action<Submission> for logging.
//Use lambda expressions to compute per-question scores and total weighted score.
//Use LINQ for advanced aggregation: group submissions by score band (grade distribution), compute class average, and identify the question with the lowest correct-answer rate (item analysis).
//Apply custom [QuestionWeightAttribute(2.0)] and[NegativeMarkingAttribute(0.25)] on question-processing methods; use reflection to read both when computing final scores, combining base weight with negative-marking penalty.
//Implement GradingSession : IDisposable managing a StreamWriter results export and a separate StreamWriter flagged-submission log; Dispose must flush / close both, continuing to close the second even if closing the first throws (defensive disposal), with a finalizer safety net and a test proving both are closed despite a simulated failure on the first.

//Exception Requirements:
//Custom InvalidSubmissionException(constructors with StudentId and reason) thrown when a submission has answers referencing non-existent QuestionIds.
//Custom IntegrityViolationException distinct from the above, thrown/logged (not necessarily fatal) when a submission fails the integrity rule, demonstrating a case where a custom exception is caught and converted into a flagged event rather than propagated.
//Built-in DivideByZeroException guarded against when computing class average with zero valid submissions (explicit check before division, with a clear custom message on the guard).
//Try-catch-finally around each submission's grading; finally must guarantee both session resources remain in a consistent, flushable state and the batch continues after any single submission's failure.

//Testing Requirements:
//Minimum 12 NUnit tests: normal submission grades correctly with weighted scoring, negative marking attribute reduces score correctly, invalid QuestionId reference throws InvalidSubmissionException, integrity rule violation raises IntegrityViolationFlagged without stopping the batch, closures for different negative-marking factors produce different scores, GradingCompleted and IntegrityViolationFlagged can both occur for the same submission (verify they are NOT mutually exclusive here, unlike other problems — document why), LINQ grade-distribution correctness, LINQ lowest-correct-rate question identification, zero-submission class average guarded correctly, both log resources close despite simulated first-stream failure, weight+negative - marking attribute combination correctness, batch continues after one invalid submission.

//Expected Behavior:
//A flagged submission must still be graded (flagging is informational, not a blocker) — this is an intentional contrast to problems where escalation/approval are mutually exclusive.
//Score must never go below zero even with heavy negative marking.
//Item analysis must correctly identify the hardest question based on aggregate correctness rate.

//Sample Input/Output:
//Input: 30 submissions, one with 15 tab switches (threshold 5) and abnormally fast completion.
//Output: that submission triggers IntegrityViolationFlagged and still receives GradingCompleted with its computed score.

//Constraints:
//10–200 submissions per batch, 5–50 questions per exam.
//Weight 0.5–5.0 per question; negative marking factor 0–1.0.
//Duplicate StudentId submissions in a batch throw a hard validation exception.


using OnlinExamProctoring.OnlinExamProctoring;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
namespace OnlinExamProctoring
{
    public class Program
    {

        // 30 submissions, one with 15 tab switches(threshold 5) and abnormally fast completion.
        // Output: that submission triggers
        // IntegrityViolationFlagged and still receives GradingCompleted with its computed score.


        public static void Main(string[] args)
        {
            

            Console.WriteLine("Enter number of submissions");
            int submissions = int.Parse(Console.ReadLine());
            //out of total submission how many tab switched
            Console.WriteLine("Enter number of tab switches");
            int tabswitch = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter start time: ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter end time: ");
            DateTime end = DateTime.Parse(Console.ReadLine());
            TimeSpan a = end - start;
          
           
                Submissions sub = new Submissions(submissions, tabswitch, true);
                Console.WriteLine(" Enter Question id");
                int questionId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter type of question");
                string type = Console.ReadLine();
                Console.WriteLine("Enter weight of each question");
                int weight = int.Parse(Console.ReadLine());
                Console.WriteLine("Number of Correct Answers: ");
                int correct = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter negative marking");
                float negativeMarking = float.Parse(Console.ReadLine());
                Question q = new Question(questionId, type, weight, correct, negativeMarking);

                Submissions.CreateScoringRule score = Submissions.CreateScore;
                score(1.0);

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
                e.ComputingClassAverageScore(total , totalScore);
                Type type2 = typeof(Submissions);
                MethodInfo[] m2 = typee.GetMethods();
                foreach (MethodInfo m3 in m)
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
