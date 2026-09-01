using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinExamProctoring
{

    //Question(QuestionId, Type, Weight, CorrectAnswer, NegativeMarking).
    internal class Question
    {
        [Required] public int QuestionId {  get; set; }
        public string Type { get; set; }
        public int Weight {  get; set; }
        public int CorrectAnswer { get; set; }
        public float NegativeMaking {  get; set; }
        public Question(int questionId , string type  , int weight , int correctAnswer , float negativeMarking) 
        {
            QuestionId = questionId;
            Type = type;
            Weight = weight;
            CorrectAnswer = correctAnswer;
            NegativeMaking  = negativeMarking;
        }
       
    }
}
