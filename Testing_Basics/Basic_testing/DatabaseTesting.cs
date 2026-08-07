using System;
using System.Collections.Generic;
using System.Text;
using Unit_testing_examples;
namespace TestProject1
{
    internal class DatabaseTesting
    {
        private DatabaseConnectivity db;
        [SetUp]
        public void setUp()
        {
            db = new DatabaseConnectivity();
            db.Connect();
        }
        [Test]
        public void testing_database_Connectivity()
        {
            Assert.That(db.Connect, Is.True);


        }
        public void testing_database_Disconnectivity()
            
        {
            Assert.That(db.Connect, Is.False);


        }

        [TearDown]
        public void tearDown()
        {
            db.Disconnect();
        }
    }
}
