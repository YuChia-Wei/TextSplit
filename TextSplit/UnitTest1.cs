using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextSplit
{
    [TestClass]
    public class UnitTest1
    {
        private string _engLength24;

        [TestInitialize]
        public void TestInitialize()
        {
            _engLength24 = "abcdefghijklmnopqrstuvxy";
        }

        [TestMethod]
        public void one_line_have_24_engString_isFull()
        {
            var stringLineCount = new StringLineCount();
            var actual = stringLineCount.IsFull(_engLength24);
            var expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ont_line_have_12_chtString_isFull()
        {
            var stringLineCount = new StringLineCount();
            var actual = stringLineCount.IsFull("一二三四五六七八九十一二");
            var expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ont_line_have_23_engString_isNotFull()
        {
            var stringLineCount = new StringLineCount();
            var actual = stringLineCount.IsFull(_engLength24.Remove(1));
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
    }

    public class StringLineCount
    {
        public bool IsFull(string inputString)
        {
            return Encoding.Default.GetBytes(inputString).Length >= 24;
        }
    }
}