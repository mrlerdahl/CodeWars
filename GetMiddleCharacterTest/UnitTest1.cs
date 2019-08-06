using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace GetMiddleCharacterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("es", GetMiddleCharacter.GetMiddle("test"));
            Assert.AreEqual("t", GetMiddleCharacter.GetMiddle("testing"));
            Assert.AreEqual("dd", GetMiddleCharacter.GetMiddle("middle"));
            Assert.AreEqual("A", GetMiddleCharacter.GetMiddle("A"));
        }
    }
}
