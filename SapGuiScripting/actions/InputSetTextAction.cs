using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using SAPFEWSELib;

namespace SapGuiScripting.actions {
    public class InputSetTextAction : SapGuiAction {

        internal TextProvider TextProvider;
        internal string path;

        public InputSetTextAction(GuiSessionProvider sessionProvider, TextProvider textProvider, string path) : base(sessionProvider) {
            this.TextProvider = textProvider;
            this.path = path;
        }

        public override void Excecute() {
            GuiSession session = GetSession();
            GuiTextField field = session.FindById(this.path) as GuiTextField;
            if (field != null) field.Text = TextProvider.GetText();
        }
    }
}

//GuiTableControl control = (GuiTableControl)session.FindById("/app/con[0]/ses[0]/wnd[0]/usr/tabsCTS/tabpTAB_MTD/ssubCSS:SAPLSEOD:0352/tblSAPLSEODPC");
//System.Diagnostics.Debug.Write(control.CurrentCol + "," + control.CurrentRow);
//GuiTextField cell = (GuiTextField)control.GetCell(control.CurrentRow, control.CurrentCol);
//foreach (var child in cell.HistoryList) {

//}
//cell.Text = "Test";
