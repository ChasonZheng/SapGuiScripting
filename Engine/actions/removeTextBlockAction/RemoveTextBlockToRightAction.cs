using Engine.text;
using SAPFEWSELib;

namespace Engine.actions.removeTextBlockAction {

    public class RemoveTextBlockToRightAction : Action {

        private readonly RemoveTextBlockToRight remove;

        public RemoveTextBlockToRightAction(params char[] separators) {
            this.remove = new RemoveTextBlockToRight(new TextBlockFinderToRight(separators));
        }

        //public RemoveTextBlockToRightAction(char separator)
        //  : this(new char[] { separator }) { }

        public void Execute(ActionContext context) {

            GuiTextField textField = context.GetSession().GetInFocus() as GuiTextField;
            if (textField == null) return;
            string text = textField.Text;
            text = remove.Remove(textField.Text, textField.CaretPosition);
            textField.Text = text;
        }

    }
}
