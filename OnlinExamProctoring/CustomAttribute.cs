using System;

namespace OnlinExamProctoring
{
    [AttributeUsage(AttributeTargets.Method)]
    public class QuestionWeightAttribute : Attribute
    {
        public double Weight { get; }

        public QuestionWeightAttribute(double weight)
        {
            Weight = weight;
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class NegativeMarkingAttribute : Attribute
    {
        public double Marks { get; }

        public NegativeMarkingAttribute(double marks)
        {
            Marks = marks;
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class UniqueAttribute : Attribute
    {
        public string Message { get; }

        public UniqueAttribute(string message)
        {
            Message = message;
        }
    }
}