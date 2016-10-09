using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPFEWSELib;
using SapGuiScripting;
using SapGuiScripting.actions;
using SapGuiScripting.@base;
using Xunit;

namespace SapGuiScriptingTest {
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
