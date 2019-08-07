using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace ComplementaryDNATest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("TTTT", ComplementaryDNA.MakeComplement("AAAA"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("TAACG", ComplementaryDNA.MakeComplement("ATTGC"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("CATA", ComplementaryDNA.MakeComplement("GTAT"));
        }
    }
}
