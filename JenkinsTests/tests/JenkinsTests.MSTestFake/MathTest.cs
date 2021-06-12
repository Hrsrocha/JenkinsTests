using FakeDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTests.MSTestFake
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        [Description("MSTest - Correct test should pass")]
        public void SumTest()
        {
            const int firstValue = 1;
            const int secondValue = 3;
            Assert.AreEqual(4, FakeMath.Sum(firstValue, secondValue));
        }
    }
}
