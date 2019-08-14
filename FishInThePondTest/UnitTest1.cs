using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace FishInThePondTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, FishInThePond.fish(""));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, FishInThePond.fish("0"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, FishInThePond.fish("6"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(2, FishInThePond.fish("1111"));
        }
        //[TestMethod]
        //public void TestMethod5()
        //{
        //    Assert.AreEqual(1, FishInThePond.fish())
        //}
        //[TestMethod]
        //public void TestMethod6()
        //{
        //    Assert.AreEqual(1, FishInThePond.fish())
        //}
        //[TestMethod]
        //public void TestMethod7()
        //{
        //    Assert.AreEqual(1, FishInThePond.fish())
        //}
        //[TestMethod]
        //public void TestMethod8()
        //{
        //    Assert.AreEqual(1, FishInThePond.fish())
        //}
        //[TestMethod]
        //public void TestMethod9()
        //{
        //    Assert.AreEqual(1, FishInThePond.fish())
        //}

    }
}
