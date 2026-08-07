using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_testing_examples
{
    public class LongRunningTask
    {
        public string LongRunning()
        {
            Thread.Sleep(3000);
            return "TaskCompleted";
        }
    }
}
