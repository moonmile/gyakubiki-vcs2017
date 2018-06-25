using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using debug352;

namespace debug352test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
