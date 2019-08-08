using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace GreedIsGoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, GreedIsGood.Score(new int[] { 2, 3, 4, 6, 2 }), "Should be 0 :-(");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(400, GreedIsGood.Score(new int[] { 4, 4, 4, 3, 3 }), "Should be 400");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1100, GreedIsGood.Score(new int[] { 6, 5, 6, 6, 5 }), "Should be 450");
        }
    }
}
