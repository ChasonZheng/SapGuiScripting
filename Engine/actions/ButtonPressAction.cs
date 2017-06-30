using System;
using SAPFEWSELib;
using GuiSession = Engine.session.GuiSession;

namespace Engine.actions {
    public class ButtonPressAction : Action {
        private readonly string path;

        public ButtonPressAction(string path) {
            this.path = path;
        }

        public void Execute(ActionContext context) {
            Console.WriteLine("Button press action execution");
            GuiSession session = context.GetSession();
            GuiButton button = (GuiButton) session.FindById(path);
            button?.Press();
        }
    }
}