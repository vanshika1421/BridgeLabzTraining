using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OnlinExamProctoring
{
    
    public class ExamGradingEngine
    {
        //Built-in DivideByZeroException guarded against when computing class average with zero valid submissions (explicit check before division, with a clear custom message on the guard).
        
        public event Action<string> GradingCompleted;
       // public delegate Predicate<Submissions> CreateIntegrityRule(TimeSpan minPlausibleDuration, int maxTabSwitches);
        public event EventHandler notification;
        public int ComputingClassAverageScore(int total , int totalScore)
        {
            try
            {
               
                if(total == 0)
                {
                    throw new DivideByZeroException();
                }
                int avg = totalScore / total;
                Console.WriteLine(avg);
                return avg;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }
       

    }
}
