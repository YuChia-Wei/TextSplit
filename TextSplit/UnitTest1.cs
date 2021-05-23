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
    }

    public class StringLineCount
    {
        public bool IsFull(string inputString)
        {
            return true;
        }
    }
}