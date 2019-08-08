using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace ArrrayDiffTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 2 }, ArrayDiff.ArraysDiff(new int[] { 1, 2 }, new int[] { 1 }));
        }
        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 2, 2 }, ArrayDiff.ArraysDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
        }
        [TestMethod]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, ArrayDiff.ArraysDiff(new int[] { 1, 2 }, new int[] { 2 }));
        }
        [TestMethod]
        public void TestMethod4()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 2 }, ArrayDiff.ArraysDiff(new int[] { 1, 2, 2 }, new int[] { }));
        }
        [TestMethod]
        public void TestMethod5()
        {
            CollectionAssert.AreEqual(new int[] { }, ArrayDiff.ArraysDiff(new int[] { }, new int[] { 1, 2 }));
        }
    }
}
