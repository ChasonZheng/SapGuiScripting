using System;
using Engine.session;
using NUnit.Framework;

namespace Test.actions {
    [TestFixture]
    public class UnknownPathExceptionTest {
        [Test]
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