using SAPFEWSELib;

namespace Engine.actions {
    public class InputSetTextAction : Action {
        private readonly string path;

        internal TextProvider TextProvider;

        public InputSetTextAction(TextProvider textProvider, string path) {
            TextProvider = textProvider;
            this.path = path;
        }

        public void Execute(ActionContext context) {
            GuiTextField textField = (GuiTextField) context.GetSession().FindById(path);
            if (textField != null) {
                textField.Text = TextProvider.GetText();
            }
        }
    }
}

//GuiTableControl control = (GuiTableControl)session.FindById("/app/con[0]/ses[0]/wnd[0]/usr/tabsCTS/tabpTAB_MTD/ssubCSS:SAPLSEOD:0352/tblSAPLSEODPC");
//System.Diagnostics.Debug.Write(control.CurrentCol + "," + control.CurrentRow);
//GuiTextField cell = (GuiTextField)control.GetCell(control.CurrentRow, control.CurrentCol);
//foreach (var child in cell.HistoryList) {

//}
//cell.Text = "Test";