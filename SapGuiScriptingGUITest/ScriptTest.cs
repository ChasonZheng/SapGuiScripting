using System.Windows.Forms;
using SapGuiHotkeysApplication;
using SapGuiScripting.session;
using SAPFEWSELib;
using Xunit;
using GuiSession = SapGuiScripting.session.GuiSession;

namespace SapGuiScriptingGUITest {
    public class ScriptTest {

        [Fact]
        public void Test() { 
            FirstSessionProvider provider = new FirstSessionProvider();
            GuiSession session = provider.GetSession();
            var count = 0;
            System.Diagnostics.Debug.Write("abas");
            session.StartRequest += delegate {
                count++;
                System.Diagnostics.Debug.Write(count);
            };

            session.FocusChanged += OnFocusChanged;
            Application.Run(new Form1());
        }

        public void OnFocusChanged(GuiSession session, GuiVComponent newFocusedComponent) {
            System.Diagnostics.Debug.Write(newFocusedComponent.Text);
            System.Diagnostics.Debug.Write(session.GetCurrentProgram());

        }
    }
}