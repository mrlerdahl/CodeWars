using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CodeWars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Right side wins!", AlphabetAirStrikeWar.AlphabetWar("z"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Let's fight again!", AlphabetAirStrikeWar.AlphabetWar("****"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("Let's fight again!", AlphabetAirStrikeWar.AlphabetWar("z*dq*mw*pb*s"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("Let's fight again!", AlphabetAirStrikeWar.AlphabetWar("zdqmwpbs"));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("Right side wins!", AlphabetAirStrikeWar.AlphabetWar("zz*zzs"));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("Left side wins!", AlphabetAirStrikeWar.AlphabetWar("*wwwwww*z*"));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("Left side wins!", AlphabetAirStrikeWar.AlphabetWar("x**dybtm*z"));
        }
    }
}
