using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinExamProctoring
{
    internal class Submissions

    {

        public delegate Func<Submissions, double> CreateScoringRule(double negativeMarkingFactor);
        //Submission(StudentId, Answers list, StartTime, EndTime, TabSwitchCount)
        public delegate Action<Submissions> logging(Submissions submissions);

       [Unique] public int StudentId { get; set; }
    public DateTime EndTime {  get; set; }
        public DateTime StartTime { get; set; }
        public int NumberOfSubmissions {  get; set; }
        public int NumberOfTabSwitches {  get; set; }
        public bool ExcessiveFastScoring {  get; set; }
        public Submissions(int numberOfSubmissions , int numberOfTabswitches , bool ExcessiveFastScoring) {
           NumberOfSubmissions = numberOfSubmissions ;
            NumberOfTabSwitches = numberOfTabswitches;
            this.ExcessiveFastScoring = ExcessiveFastScoring;

        }
        public Submissions(int StudentId ,DateTime startTime , DateTime endTime , int numberOfTabswitches)
        {
            this.StudentId = StudentId ;
            StartTime = startTime;
            EndTime = endTime ;
            NumberOfTabSwitches = numberOfTabswitches;
        }
        


        public static Func<Submissions, double> CreateScore(double NegativeMarkingfactor)
        {
            return x =>
            {
               
                double score = 1.0;

                if (x.NumberOfTabSwitches > 3)
                    score -= 0.1 * x.NumberOfTabSwitches;

                if (x.ExcessiveFastScoring)
                    score -= 0.5;

                score -= NegativeMarkingfactor;
                Console.WriteLine(score>0?score :0);
                return Math.Max(0.0, score);
            };
        }



    }
}


//An online assessment platform needs to grade submitted exams using configurable, question - type - specific scoring rules,
//detect potential integrity violations (e.g., suspiciously fast completion, excessive tab-switch events) via composable rules,
//and notify instructors of flagged submissions separately from normal grade-ready notifications. Question types carry metadata
//describing scoring weight and negative marking. A grading session manages a results-export resource and a flagged-submission
//log, both needing correct disposal across a full class batch.
