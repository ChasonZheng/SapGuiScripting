using System.Windows.Forms;
using SapGuiScripting.actions;

namespace SapGuiScriptingGUITest {
    public class HotKeyTest {
        private readonly Action actionToTest;

        public HotKeyTest(Action actionToTest) {
            this.actionToTest = actionToTest;
        }

        public void Run() {
            Application.Run(new TestForm(actionToTest));
        }
    }
}