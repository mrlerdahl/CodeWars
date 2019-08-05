using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("42 -9", HighestLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}
