using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using debug350;

namespace debug350test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddNumber()
        {
            var t = new TargetClass();
            int ans = t.add(10, 20);
            Assert.AreEqual(30, ans);
        }
    }
}
