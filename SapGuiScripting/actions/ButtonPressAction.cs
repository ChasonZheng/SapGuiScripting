using System;
using SAPFEWSELib;

namespace SapGuiScripting.actions {
    public class ButtonPressAction : SapGuiAction {
        private readonly string path;

        public ButtonPressAction(GuiSessionProvider sessionProvider, string path) : base(sessionProvider) {
            this.path = path;
        }
        public override void Excecute() {
            GuiSession session = GetSession();
            GuiButton button = session.FindById(path) as GuiButton;
            button?.Press();
        }
    }
}

