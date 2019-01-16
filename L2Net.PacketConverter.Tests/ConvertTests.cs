using L2Net.PacketConverter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L2Net.PacketConverter.Tests
{
    [TestClass]
    public class ConvertTests
    {
        [DataRow("52", 82)]
        public void FromByteToHexTest(string expected, byte input)
        {
            Assert.AreEqual(expected, Convert.FromByteToHex(input));
        }

        [DataRow("52 00", 82)]
        [DataRow("FF FF", 99999999)]
        public void FromInt16ToHexTest(string expected, byte bytee)
        {
            Assert.AreEqual(expected, Convert.FromInt16ToHex(bytee));
        }

        [DataRow("52 00 00 00", 82)]
        [DataRow("52 00 6F 00", 7274578)]
        [DataRow("FF FF FF F7", 4294967295)]
        public void FromInt32ToHexTest(string expected, int int32)
        {
            Assert.AreEqual(expected, Convert.FromInt32ToHex(int32));
        }

        [DataRow("52 00 00 00 00 00 00 00", 7274578)]
        [DataRow("FF FF C0 6F F2 86 23 00", 9999999999999999)]                                            
        [DataRow("FF FF FF FF FF FF FF F7", 9223372036854775807)]
        public void FromInt64ToHexTest(string expected, System.Int64 int64)
        {
            Assert.AreEqual(expected, Convert.FromInt64ToHex(int64));
        }

        [DataTestMethod]
        [DataRow(76, "4C")]
        [DataRow(76, "4C 00 32 00 4E 00 65 00 74 00 52 00 6F 00 63 00 6B 00")]
        public void FromHexToByteTest(int expected, string hex)
        {
            Assert.AreEqual(expected, Convert.FromHexToByte(hex));
        }

        [DataTestMethod]
        [DataRow(76, "4C")]
        [DataRow(76, "4C 00 32 00 4E 00 65 00 74 00 52 00 6F 00 63 00 6B 00")]
        public void FromHexToInt16Test(int expected, string hex)
        {
            Assert.AreEqual(expected, Convert.FromHexToInt16(hex));
        }

        [DataTestMethod]
        [DataRow(76, "4C")]
        [DataRow(3276876, "4C 00 32 00 4E 00 65 00 74 00 52 00 6F 00 63 00 6B 00")]
        public void FromHexToInt32Test(int expected, string hex)
        {
            Assert.AreEqual(expected, Convert.FromHexToInt32(hex));
        }

        [DataTestMethod]
        [DataRow(76, "4C")]
        [DataRow(1500100900, "24 B9 69 59")]
        [DataRow(1500100900, "24 B9 69 59 00 00 00 00")]
        public void FromHexToInt64Test(int expected, string hex)
        {
            Assert.AreEqual(expected, Convert.FromHexToInt64(hex));
        }

        [DataTestMethod]
        [DataRow("4C 32 4E 65 74 52 6F 63 6B", "L2NetRock")]
        public void FromStringToHexNormalTest(string expected, string hex)
        {
            Assert.AreEqual(expected, Convert.FromStringToHex(hex, false));
        }

        [DataTestMethod]
        [DataRow("4C 00 32 00 4E 00 65 00 74 00 52 00 6F 00 63 00 6B 00", "L2NetRock")]
        public void FromStringToHexWithSeparationTest(string expected, string hex)
        {
            Assert.AreEqual(expected, Convert.FromStringToHex(hex));
        }

        [DataTestMethod]
        [DataRow("L2NetRock", "4C 32 4E 65 74 52 6F 63 6B")]
        [DataRow("L2NetRock", "4C 00 32 00 4E 00 65 00 74 00 52 00 6F 00 63 00 6B 00")]
        public void FromHexToStringTest(string expected, string hex)
        {
            Assert.AreEqual(expected, Convert.FromHexToString(hex));
        }
    }
}
