using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;

namespace task1Test
{
    [TestClass]
    public class ACoderEncodeTest
    {
        [TestMethod]
        public void TestMethodACoderEncode()
        {
            ACoder coder = new ACoder();
            string arg1 = "abc";
            string expected = "bcd";
            string result = coder.Encode(arg1);
            Assert.AreEqual(expected, result);
        }
    }
}
