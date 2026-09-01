using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinExamProctoring
{
    internal class Unique : System.Attribute
    {
        public string Message {  get; set; }
       
       public void UniqueAttribute(String message)
        {
            Message = message;
        }
    }
        internal class NegativeMarking
    {
       
        public double negativemark { get; set; }
        public void NegativeMarkingAttribute(double marks)
        {
            negativemark = marks;
        }
        }
    internal class QuestionWeight
    {
        public double Weight { get; set; }
        public void QuestionWeightAttribute(double weight)
        {
            Weight = weight;
        }
    }


    
}
