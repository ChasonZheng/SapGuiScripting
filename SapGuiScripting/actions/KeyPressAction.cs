using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SapGuiScripting.actions {
    class KeyPressAction : Action{

        private readonly string key;

        public KeyPressAction(string key) {
            this.key = key;
        }

        public void Excecute() {
            SendKeys.SendWait(key);
        }
    }
}
