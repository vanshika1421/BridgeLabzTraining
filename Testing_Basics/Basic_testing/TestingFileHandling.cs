using System;
using System.Collections.Generic;
using System.Text;
using Unit_testing_examples;

namespace TestProject1
{
    internal class TestingFileHandling
    {
        private FileHandling fh;
        private string fileName;
        [SetUp]
        public void setUp()
        {
           fh = new FileHandling();
            fileName = "Hello.txt";
        }
        [Test]
        public void checking_file_handling()
        {

            string content = "Vanshika";
            fh.WriteToFile(fileName , content);
            string result = fh.readFromFile(fileName);
            Assert.That(result ,Is.EqualTo(content));
        }
    }
}
