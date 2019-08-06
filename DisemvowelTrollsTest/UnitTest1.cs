using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace DisemvowelTrollsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemvowelTrolls.Disemvowel("This website is for losers LOL!"));
        }
    }
}
