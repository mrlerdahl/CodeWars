using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(6, VowelCount.GetVowelCount("lookingforvowels"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, VowelCount.GetVowelCount("codingisfun"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(11, VowelCount.GetVowelCount("boolikieroucbefaoudnvc"));
        }
    }
}
