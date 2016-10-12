using SapGuiScripting.actions;
using SapGuiScripting.@base;
using SAPFEWSELib;
using Xunit;

namespace SapGuiScriptingTest.actions {
    public class ButtonPressActionTest {

        [Fact]
        public void TestSimple() {
            FirstSessionProvider provider = new FirstSessionProvider();
            GuiSession session = provider.GetSession();
            ButtonPressAction action = new ButtonPressAction("/app/con[0]/ses[0]/wnd[0]/tbar[0]/btn[15]");

            action.Execute(session);
            Assert.True(action.IsExecutable(session));

        }


    }
}
