using Engine.text;
using SAPFEWSELib;

namespace Engine.actions.removeTextBlockAction {

    public class RemoveTextBlockToLeftAction : Action {

        private readonly RemoveTextBlockToLeft remove;

        public RemoveTextBlockToLeftAction(char[] separators) {
            this.remove = new RemoveTextBlockToLeft(separators);
        }

        public RemoveTextBlockToLeftAction(char separator)
            : this(new char[] { separator }) { }

        public void Execute(ActionContext context) {

            GuiTextField textField = context.GetSession().GetInFocus() as GuiTextField;
            if (textField == null) return;
            string text = textField.Text;
            textField.Text = remove.Remove(textField.Text);
            textField.CaretPosition = textField.Text.Length - 1;

        }

    }
}
