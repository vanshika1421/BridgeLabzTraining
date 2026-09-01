using System;

namespace OnlinExamProctoring
{
    public class InvalidSubmissionException : Exception
    {
        public int StudentId { get; }

        public InvalidSubmissionException(int studentId, string reason)
            : base($"Invalid submission for Student {studentId}: {reason}")
        {
            StudentId = studentId;
        }
    }

    public class IntegrityViolationException : Exception
    {
        public int StudentId { get; }

        public IntegrityViolationException(int studentId, string reason)
            : base($"Integrity violation for Student {studentId}: {reason}")
        {
            StudentId = studentId;
        }
    }
}