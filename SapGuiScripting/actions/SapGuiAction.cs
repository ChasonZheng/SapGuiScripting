using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPFEWSELib;

namespace SapGuiScripting.actions {
    public interface SapGuiAction {
        bool IsExecutable(GuiSession session);
        void Execute(GuiSession session);
    }
}
