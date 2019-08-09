using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace ConsonateValueTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(26, ConsonateValue.Solve("zodiac"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(80, ConsonateValue.Solve("chruschtschov"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(38, ConsonateValue.Solve("khrushchev"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(57, ConsonateValue.Solve("strength"));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(73, ConsonateValue.Solve("catchphrase"));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(103, ConsonateValue.Solve("twelfthstreet"));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(80, ConsonateValue.Solve("mischtschenkoana"));
        }
    }
}
