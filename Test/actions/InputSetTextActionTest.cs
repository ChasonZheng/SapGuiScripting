using Moq;
using Engine.actions;
using Engine.session;
using Xunit;

namespace Test.actions {
    public class InputSetTextActionTest {
        [Fact]
        public void TestSimple() {
            FirstSessionProvider provider = new FirstSessionProvider();
            var contextMock = new Mock<ActionContext>();
            FirstSessionProvider sessionProvider = new FirstSessionProvider();
            contextMock.Setup(context => context.GetSession()).Returns(sessionProvider.GetSession());


            //InputSetTextAction action = new InputSetTextAction("abc", );

        }
    }
}