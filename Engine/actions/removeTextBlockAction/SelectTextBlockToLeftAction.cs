using Engine.text;
using SAPFEWSELib;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Engine.actions.removeTextBlockAction {

    public class SelectTextBlockToLeftAction : Action {

        //private readonly RemoveTextBlockToLeft remove;
        private readonly TextBlockFinder finder;

        public SelectTextBlockToLeftAction(params char[] separators) {
            this.finder = new TextBlockFinderToLeft(separators);
        }

        public void Execute(ActionContext context) {
            InputSimulator simulator = new InputSimulator();
            simulator.Keyboard.KeyUp(VirtualKeyCode.CONTROL);

            SendKeys.SendWait("+(a)");
            return;

            GuiTextField textField = context.GetSession().GetInFocus() as GuiTextField;
            if (textField == null) return;
            string text = textField.Text;
            int index = finder.GetIndex(textField.Text, textField.CaretPosition);
            int difference = textField.CaretPosition - index;
            if (difference == 0) return;
            string command = "+(";
            for (var i = 0; i <= difference; i++) {
                command += "{LEFT}";
            }
            command += ")";
            SendKeys.SendWait(command);
        }

    }
}
