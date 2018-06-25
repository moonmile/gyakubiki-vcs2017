using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using debug354;

namespace debug354test
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
        [TestMethod]
        public void TestAddString()
        {
            var t = new TargetClass();
            var ans = t.add("増田", "智明");
            Assert.AreEqual("増田智明", ans);
        }
        [TestMethod]
        public void TestNull()
        {
            var t = new TargetClass();
            var obj = t.CreatePointer(-1, -1);
            Assert.IsNull(obj);
            obj = t.CreatePointer(10, 20);
            Assert.IsNotNull(obj);
            Assert.AreEqual(10, obj.X);
            Assert.AreEqual(20, obj.Y);
        }
    }
}
