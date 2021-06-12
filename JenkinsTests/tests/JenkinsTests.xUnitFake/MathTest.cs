using FakeDomain;
using Xunit;

namespace JenkinsTests.xUnitFake
{
    public class MathTest
    {
        [Fact(DisplayName = "xUnit - Correct test should pass")]
        public void SumTest()
        {
            const int firstValue = 1;
            const int secondValue = 3;

            Assert.Equal(4, FakeMath.Sum(firstValue, secondValue));
        }
    }
}
