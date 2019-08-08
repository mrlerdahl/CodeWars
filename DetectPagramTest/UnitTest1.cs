using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace DetectPagramTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, DetectPangram.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, DetectPangram.IsPangram("This senetence does not have all the letters in the alphabet!!!"));
        }
    }
}
