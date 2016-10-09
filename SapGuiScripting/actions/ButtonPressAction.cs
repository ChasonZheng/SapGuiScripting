using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using SAPFEWSELib;

namespace SapGuiScripting.actions {
    [SuppressMessage("ReSharper", "SuspiciousTypeConversion.Global")]
    public class ButtonPressAction : SapGuiAction {
        private readonly string path;

        public ButtonPressAction(string path) {
            this.path = path;
        }

        public bool IsExecutable(GuiSession session) {
            return GetComponent(session) is GuiButton;
        }

        public void Execute(GuiSession session) {
            GuiComponent component = GetComponent(session);
            GuiButton button = (GuiButton)component;
            button.Press();
        }

        private GuiComponent GetComponent(GuiSession session) {
            return session.FindById(path);
        }
    }
}
