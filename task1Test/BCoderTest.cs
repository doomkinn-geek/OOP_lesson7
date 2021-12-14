using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;

namespace task1Test
{
    [TestClass]
    public class BCoderTest
    {
        [TestMethod]
        public void TestMethodBCoderDecode()
        {
            BCoder coder = new BCoder();
            string arg1 = "zyx";
            string expected = "abc";
            string result = coder.Decode(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodBCoderEncode()
        {
            BCoder coder = new BCoder();
            string arg1 = "abc";
            string expected = "zyx";
            string result = coder.Encode(arg1);
            Assert.AreEqual(expected, result);
        }
    }
}
