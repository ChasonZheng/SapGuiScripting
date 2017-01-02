using System.Diagnostics;
using System.Windows.Forms;
using SapGuiScripting.session;
using SAPFEWSELib;

namespace SapGuiHotkeysApplication {
    internal class ScriptTest {
        public static void Main(string[] args) {
            FirstSessionProvider provider = new FirstSessionProvider();
            GuiSession session = provider.GetSession();
            var count = 0;
            session.StartRequest += delegate {
                count++;
                Debug.Write(count);
            };
            Application.Run(new Form1());
        }
    }
}