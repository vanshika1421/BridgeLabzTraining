using Unit_testing_examples;
namespace TestProject1
{
    //public class Tests
    //{

    //   // private Calculator calculator;
    //    private PrimeNumber primeNumber;
    //    [SetUp]
    //    public void Setup()
    //    {
    //       // calculator = new Calculator();
    //        primeNumber = new PrimeNumber();
    //    }

      //  [Test]
        
        // public void checkPrime()
        //{
        //    //Arrange
        //    var primeNumber = new PrimeNumber();
        //    int n = 7;
        //    Boolean expec= true;
           

        //    Assert.That(expec , Is.True(PrimeNumber.Prime(n)));
            //var Calculator = new Calculator();
            //int a = 5;
            //int b = 10;
            //int expected = 15;
            ////Act
            //int result = Calculator.Add(a, b);
            ////Assert
            //Assert.That(expected, Is.EqualTo(result));



  //      }
//    }
//}

//Arrange act assert


namespace TestProject1
    {
        public class Tests
        {
            private PrimeNumber primeNumber;
             private Calculator calculator;
            private EvenOdd evenOdd;
            [SetUp]
            public void Setup()
            {
                calculator = new Calculator();
                primeNumber = new PrimeNumber();
                evenOdd = new EvenOdd();

            }

            [Test]
            public void Check_Even_Number()
            {
                int n = 4;
                int res = evenOdd.CheckEven(n);
                Assert.That(res, Is.EqualTo(1));
            }
            public void Check_Odd_Number()
            {
                int n = 5;
                int res = evenOdd.CheckOdd(n);
                Assert.That(res, Is.EqualTo(1));
            }

            [Test]
            public void Check_Prime_Number()
            {
                // Arrange
                int number = 7;

                // Act
                bool result = primeNumber.IsPrime(number);

                // Assert
                var Calculator = new Calculator();
                int a = 5;
                int b = 10;
                int expected = 15;
                //Act
                int ans = Calculator.Add(a, b);
                //Assert
                Assert.That(expected, Is.EqualTo(ans));
                Assert.That(result, Is.True);
            }
        }
    }
}