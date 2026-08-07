using System;
using System.Collections.Generic;
using System.Text;
using Unit_testing_examples;
namespace TestProject1
{
    internal class LongRunningTaskTesting
    {
        private LongRunningTask lr;
        [SetUp]
        public void setUp()
        {
            lr = new LongRunningTask();
        }
        [Test]
        [Timeout(4000)]
        public void testing_Long_run_task()
        {
           string res = lr.LongRunning();
            Assert.That(res, Is.EqualTo("TaskCompleted"));
        }

    }
}
