using System.Windows.Forms;
using Application;
using Engine.session;
using SAPFEWSELib;

using GuiSession = Engine.session.GuiSession;

namespace UITest {
    public class ScriptTest : NeinHandler {
        private GuiSession thisSession;

        public void Test() {
            ActiveSessionProvider provider = new ActiveSessionProvider();
            GuiSession session = provider.GetSession();

            //ActiveSession session = new ActiveSession(new ActiveSessionProvider());
            //session.StartRequest += OnStartRequest;
            //session.FocusChanged += OnFocusChanged;
            Form1 form = new Form1();
            //form.RegisterOnClick(this);
           // Application.Run(form);
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
        }
    }
}