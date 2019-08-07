using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
namespace SquareOfSquaresTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(false, SquareOfSquares.IsSquare(-1), "negative numbers aren't square numbers");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, SquareOfSquares.IsSquare(3), "3 isn't a square number");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, SquareOfSquares.IsSquare(4), "4 is a square number");
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(true, SquareOfSquares.IsSquare(25), "25 is a square number");
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(false, SquareOfSquares.IsSquare(26), "26 isn't a square number");
        }
    }
}
