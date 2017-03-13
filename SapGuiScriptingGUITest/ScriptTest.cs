using System.Windows.Forms;
using SapGuiHotkeysApplication;
using SapGuiScripting.session;
using SAPFEWSELib;
using Xunit;
using Xunit.Abstractions;
using GuiSession = SapGuiScripting.session.GuiSession;

namespace SapGuiScriptingGUITest {
    public class ScriptTest : NeinHandler {
        public static ITestOutputHelper output;
        private GuiSession thisSession;

        public ScriptTest(ITestOutputHelper output) {
            ScriptTest.output = output;
        }

        [Fact]
        public void Test() {
            //ActiveSessionProvider provider = new ActiveSessionProvider();
            //GuiSession session = provider.GetSession();

            ActiveSession session = new ActiveSession(new ActiveSessionProvider());
            //session.StartRequest += OnStartRequest;
            session.FocusChanged += OnFocusChanged;
            Form1 form = new Form1();
            //form.RegisterOnClick(this);
            Application.Run(form);
        }

        public void OnFocusChanged(GuiSession session, GuiVComponent newFocusedComponent) {
            System.Diagnostics.Debug.WriteLine(session.ToString());
            //   output.WriteLine(session.ToString());
        }

        public void OnStartRequest(GuiSession session) {
            System.Diagnostics.Debug.WriteLine("on_start_request angekommen");
            System.Diagnostics.Debug.WriteLine(session.ToString());
            //   output.WriteLine(session.ToString());
        }

        public void Handle() {
            System.Threading.Thread.Sleep(1000);
            output.WriteLine(thisSession.GetCurrentProgram());
        }
    }
}