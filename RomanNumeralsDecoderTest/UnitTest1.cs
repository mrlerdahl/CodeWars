using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace RomanNumeralsDecoderTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, RomanNumeralsDecoder.Solution("I"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(99, RomanNumeralsDecoder.Solution("XCIX"));
        }
    }
}
