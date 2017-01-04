using Moq;
using SapGuiScripting.actions;
using SapGuiScripting.session;
using Xunit;

namespace SapGuiScriptingTest.actions {
    public class InputSetTextActionTest {
        [Fact]
        public void TestSimple() {
            FirstSessionProvider provider = new FirstSessionProvider();
            var contextMock = new Mock<ActionContext>();
            FirstSessionProvider sessionProvider = new FirstSessionProvider();
            contextMock.Setup(context => context.GetSession()).Returns(sessionProvider.GetSession());


            //InputSetTextAction action = new InputSetTextAction();
            
            //Assert.True(action.IsExecutable(session));
        }
    }
}