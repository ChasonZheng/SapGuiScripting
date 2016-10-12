using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPFEWSELib;

namespace SapGuiScripting.actions {
    public class InputSetTextAction : SapGuiAction {
        public bool IsExecutable(GuiSession session) {
            return true;
        }

        public void Execute(GuiSession session) {
            GuiTableControl control = (GuiTableControl) session.FindById("/app/con[0]/ses[0]/wnd[0]/usr/tabsCTS/tabpTAB_MTD/ssubCSS:SAPLSEOD:0352/tblSAPLSEODPC");
            System.Diagnostics.Debug.Write(control.CurrentCol + "," + control.CurrentRow);
            GuiTextField cell = (GuiTextField)control.GetCell(control.CurrentRow, control.CurrentCol);
            cell.Text = "Test";
        }
    }
}
