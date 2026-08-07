using regex_code;
namespace Regex_code_testing

{
    public class Tests
    {
        private UserName_Validator uv;
        [SetUp]
        public void Setup()
        {
            uv = new UserName_Validator();
        }

        [Test]
        public void testing_username_validation()
        {

            string str = "user_123";
            Assert.That(uv.username_valid(str), Is.True);
        }
    }
}
