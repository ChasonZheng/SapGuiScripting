using Moq;
using Engine.actions;
using Engine.session;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.actions {
    [TestClass]
    public class InputSetTextActionTest {
        [TestMethod]
        public void TestSimple() {
            FirstSessionProvider provider = new FirstSessionProvider();
            var contextMock = new Mock<ActionContext>();
            var textMock = new Mock<TextProvider>();
            FirstSessionProvider sessionProvider = new FirstSessionProvider();
            contextMock.Setup(context => context.GetSession()).Returns(sessionProvider.GetSession());
            textMock.Setup(text => text.GetText()).Returns("ABC");

            InputSetTextAction action = new InputSetTextAction(textMock.Object, "/app/con[0]/ses[0]/wnd[0]/usr/txtRSYST-BNAME");
            action.Execute(contextMock.Object);

        }
    }
}