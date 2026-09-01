using System.ComponentModel.DataAnnotations;

namespace OnlinExamProctoring
{
    public class Question
    {
        [Required]
        public int QuestionId { get; set; }

        public string Type { get; set; }
        public double Weight { get; set; }
        public string CorrectAnswer { get; set; }
        public double NegativeMarking { get; set; }

        public Question(int questionId, string type, double weight, string correctAnswer, double negativeMarking)
        {
            QuestionId = questionId;
            Type = type;
            Weight = weight;
            CorrectAnswer = correctAnswer;
            NegativeMarking = negativeMarking;
        }
    }
}