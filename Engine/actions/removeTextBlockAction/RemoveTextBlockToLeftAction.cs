using Engine.text;
using SAPFEWSELib;

namespace Engine.actions.removeTextBlockAction {

    public class RemoveTextBlockToLeftAction : Action {

        private readonly RemoveTextBlockToLeft remove;

        public RemoveTextBlockToLeftAction(params char[] separators) {
            this.remove = new RemoveTextBlockToLeft(new TextBlockFinderToLeft(separators));
        }

        public const int VK_ENTER = 0x0D; //Right Control key code
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag

        public void Execute(ActionContext context) {

            GuiTextField textField = context.GetSession().GetInFocus() as GuiTextField;
            if (textField == null) return;
            string text = textField.Text;
            text = remove.Remove(textField.Text, textField.CaretPosition);

            int oldPosition = textField.CaretPosition;
            int difference = textField.Text.Length - text.Length;
            int newPosition = textField.CaretPosition - difference;

            textField.CaretPosition = newPosition;
            textField.Text = text;
        }

    }
}
