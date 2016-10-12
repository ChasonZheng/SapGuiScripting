using SapGuiScripting.actions;
using SapGuiScripting.@base;
using SAPFEWSELib;
using Xunit;

namespace SapGuiScriptingTest.actions {
    public class InputSetTextActionTest {

        [Fact]
        public void TestSimple() {
            FirstSessionProvider provider = new FirstSessionProvider();
            GuiSession session = provider.GetSession();

            InputSetTextAction action = new InputSetTextAction();
            action.Execute(session);
            //Assert.True(action.IsExecutable(session));

        }
    }
}
