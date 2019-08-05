using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hi!", RemoveExclamation.Remove("Hi!"));
            Assert.AreEqual("Hi!!!", RemoveExclamation.Remove("Hi!!!"));
            Assert.AreEqual("Hi", RemoveExclamation.Remove("!Hi"));
            Assert.AreEqual("Hi!", RemoveExclamation.Remove("!Hi!"));
            Assert.AreEqual("Hi Hi!", RemoveExclamation.Remove("Hi! Hi!"));
            Assert.AreEqual("Hi", RemoveExclamation.Remove("Hi"));
        }
    }
}
