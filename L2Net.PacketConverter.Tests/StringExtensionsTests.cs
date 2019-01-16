using L2Net.PacketConverter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L2Net.PacketConverter.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void NormalizeStringTest()
        {
            Assert.AreEqual("52 00", "52-00".NormalizeString());
        }

        [TestMethod]
        [DataRow("5200", "52-00")]
        [DataRow("5200", "52 00")]
        public void RemoveSeparatorsTest(string expected, string hex)
        {
            Assert.AreEqual(expected, hex.RemoveSeparators());
        }
    }
}
