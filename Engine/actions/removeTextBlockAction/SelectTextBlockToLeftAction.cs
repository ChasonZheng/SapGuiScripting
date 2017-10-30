//using AutoHotkey.Interop;
using Engine.text;
using SAPFEWSELib;
using WindowsInput;

namespace Engine.actions.removeTextBlockAction {

    public class SelectTextBlockToLeftAction : Action {

        //private readonly RemoveTextBlockToLeft remove;
        private readonly TextBlockFinder finder;

        public SelectTextBlockToLeftAction(params char[] separators) {
            this.finder = new TextBlockFinderToLeft(separators);
        }




        public void Execute(ActionContext context) {
            InputSimulator simulator = new InputSimulator();
            //simulator.Keyboard.KeyUp(VirtualKeyCode.CONTROL);
            //SetKeyboardState(new byte[256]);
            //simulator.Keyboard.KeyUp(VirtualKeyCode.CONTROL);

            //grab a copy of the AutoHotkey singleton instance
            //var ahk = AutoHotkeyEngine.Instance;

            //GuiTextField textField = context.GetSession().GetInFocus() as GuiTextField;
            //if (textField == null) return;
            //string text = textField.Text;
            //int index = finder.GetIndex(textField.Text, textField.CaretPosition);
            //System.Console.WriteLine(index);
            //int difference = textField.CaretPosition - index;
            //System.Console.WriteLine(difference);
            //if (difference == 0) return;
            //string command = "Send, {Shift Down}";
            //for (var i = 0; i <= difference; i++) {
            //    command += "{LEFT}";
            //}
            //command += "{Shift Up}";
            //System.Console.WriteLine(command);
            //ahk.ExecRaw(command);
        }

    }
}
