using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinExamProctoring
{

    using System.Collections.Generic;
    using System.Text;

    namespace OnlinExamProctoring
    {
        internal class InvalidSubmissionException : Exception
        {
            
            public InvalidSubmissionException(string message) : base(message)
            {

            }
          
        }
        internal class IntegrityViolationException : Exception
        {
            public IntegrityViolationException() : base(){ }
        }
    }
}