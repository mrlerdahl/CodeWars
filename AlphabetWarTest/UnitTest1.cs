using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace AlphabetWarTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Right side wins!", AlphabetWar.War("z"));
            Assert.AreEqual("Let's fight again!", AlphabetWar.War("zdqmwpbs"));
            Assert.AreEqual("Right side wins!", AlphabetWar.War("zzzzs"));
            Assert.AreEqual("Left side wins!", AlphabetWar.War("wwwwwwz"));
        }
    }
}
