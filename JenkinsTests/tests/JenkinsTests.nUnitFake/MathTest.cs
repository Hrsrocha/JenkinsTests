using FakeDomain;
using NUnit.Framework;

namespace JenkinsTests.nUnitFake
{
    public class MathTest
    {
        [Test(Description = "nUnit - Correct test should pass")]
        public void SumTest()
        {
            const int firstValue = 1;
            const int secondValue = 3;
            Assert.AreEqual(4, FakeMath.Sum(firstValue, secondValue));
        }
    }
}