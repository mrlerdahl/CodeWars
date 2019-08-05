using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LengthTest()
        {
            Assert.AreEqual(false, ValidatePIN.ValidatePin("1"), "Wrong output for \"1\"");
            Assert.AreEqual(false, ValidatePIN.ValidatePin("12"), "Wrong output for \"12\"");
            Assert.AreEqual(false, ValidatePIN.ValidatePin("123"), "Wrong output for \"123\"");
            Assert.AreEqual(false, ValidatePIN.ValidatePin("12345"), "Wrong output for \"12345\"");
            Assert.AreEqual(false, ValidatePIN.ValidatePin("1234567"), "Wrong output for \"1234567\"");
            Assert.AreEqual(false, ValidatePIN.ValidatePin("-1234"), "Wrong output for \"-1234\"");
            Assert.AreEqual(false, ValidatePIN.ValidatePin("1.234"), "Wrong output for \"1.234\"");
            Assert.AreEqual(false, ValidatePIN.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
            Assert.AreEqual(false, ValidatePIN.ValidatePin("00000000"), "Wrong output for \"00000000\"");
        }

        [TestMethod]
        public void NonDigitTest()
        {
            Assert.AreEqual(false, ValidatePIN.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, ValidatePIN.ValidatePin(".234"), "Wrong output for \".234\"");
        }

        [TestMethod]
        public void ValidTest()
        {
            Assert.AreEqual(true, ValidatePIN.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, ValidatePIN.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, ValidatePIN.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, ValidatePIN.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, ValidatePIN.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, ValidatePIN.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, ValidatePIN.ValidatePin("090909"), "Wrong output for \"090909\"");
        }
    }
}
