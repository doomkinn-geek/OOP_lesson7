using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using task1;

namespace task1Test
{
    [TestClass]
    public class ACoderDecodeTest
    {
        [TestMethod]
        public void TestMethodACoderEncode()
        {
            ACoder coder = new ACoder();
            string arg1 = "bcd";
            string expected = "abc";
            string result = coder.Decode(arg1);
            Assert.AreEqual(expected, result);
        }
    }    
}
