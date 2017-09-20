using System;
using Engine.session;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.actions {
    [TestClass]
    public class UnknownPathExceptionTest {
        [TestMethod]
        public void Test() {
            FirstSessionProvider provider = new FirstSessionProvider();
            try {
                provider.GetSession().FindById("ASdASD");
                Assert.IsTrue(false);
            }
            catch (InvalidPathException) {
                Assert.IsTrue(true);
            }
        }
    }
}