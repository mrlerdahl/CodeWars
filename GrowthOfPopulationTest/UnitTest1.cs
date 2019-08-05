using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    [TestClass]
    public class UnitTest1
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1()
        {
            testing(GrowthOfPopulation.NbYear(1500, 5, 100, 5000), 15);
            testing(GrowthOfPopulation.NbYear(1500000, 2.5, 10000, 2000000), 10);
            testing(GrowthOfPopulation.NbYear(1500000, 0.25, 1000, 2000000), 94);
        }
    }
}
