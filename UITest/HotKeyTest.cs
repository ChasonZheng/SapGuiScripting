using System.Windows.Forms;
using Engine.actions;

namespace UITest {
    public class HotKeyTest {
        private readonly Action actionToTest;

        public HotKeyTest(Action actionToTest) {
            this.actionToTest = actionToTest;
        }

        public void Run() {
            //Application.Run(new TestForm(actionToTest));
        }
    }
}