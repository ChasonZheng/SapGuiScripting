using System;
using SapGuiScripting.session;
using Xunit;

namespace SapGuiScriptingTest.actions {
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