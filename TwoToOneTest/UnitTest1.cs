using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}
