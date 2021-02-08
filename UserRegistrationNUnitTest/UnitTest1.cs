using NUnit.Framework;
using UserRegistrationUsingNUnitTest;
namespace UserRegistrationNUnitTest
{
    public class Tests
    {
        UserRegex userRegex;
        [SetUp]
        public void Setup()
        {
            userRegex = new UserRegex();
        }

        [Test]
        public void FirstNameReturnTrue()
        {
           bool result =userRegex.FirstNameRegex("Dilip");
            Assert.IsTrue(result);
        }
        [Test]
        public void FirstNameReturnFalse()
        {
            bool result = userRegex.FirstNameRegex("dilip");
            Assert.IsFalse(result);
        }
    }
}