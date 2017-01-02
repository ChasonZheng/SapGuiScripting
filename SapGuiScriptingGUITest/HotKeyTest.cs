using System.Windows.Forms;
using SapGuiScripting.actions;
using static System.Windows.Forms.Application;

namespace SapGuiScriptingTest {
    public class HotKeyTest {
        private Action actionToTest;

        public HotKeyTest(Action actionToTest) {
            this.actionToTest = actionToTest;
        }

        public void Run() {
            Application.Run(new TestForm(actionToTest));
        }
    }
}