using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using debug348;

namespace debug348test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new TargetClass();
            Assert.AreEqual(30, t.add(10, 20));
        }
    }
}
