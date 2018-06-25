using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using debug351;

namespace debug351test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new TargetClass();
            var ans = t.add("増田", "智明");
            Assert.AreEqual("増田智明", ans);
        }
    }
}
