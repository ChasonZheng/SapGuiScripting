using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using SAPFEWSELib;

namespace SapGuiScripting.actions {
    public abstract class SapGuiAction : Action{
        private readonly GuiSessionProvider provider;

        protected SapGuiAction(GuiSessionProvider provider) {
            this.provider = provider;
        }

        protected GuiSession GetSession() {
            return this.provider.GetSession();
        }

        public abstract void Excecute();
    }
}
