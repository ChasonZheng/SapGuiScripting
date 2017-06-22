using System;
using Engine.session;
using Xunit;

namespace Test.actions {
    public class UnknownPathExceptionTest {
        [Fact]
        public void Test() {
            FirstSessionProvider provider = new FirstSessionProvider();
            try {
                provider.GetSession().FindById("ASdASD");
                Xunit.Assert.True(false);
            }
            catch (InvalidPathException) {
                Xunit.Assert.True(true);
            }
        }
    }
}