using System.Windows.Forms;

namespace Engine.controller.hotkeys { 

    public class Hotkey {

        private readonly ModifierKeys modifier;
        private readonly Keys key;

        public Hotkey(ModifierKeys modifier, Keys key) {
            this.modifier = modifier;
            this.key = key;
        }

        public override int GetHashCode() {
            return modifier.GetHashCode() ^ key.GetHashCode();
        }

        public override bool Equals(object obj) {
            return Equals(obj as Hotkey);
        }

        public bool Equals (Hotkey hotkey) {
            return hotkey != null && hotkey.key == this.key && hotkey.modifier == this.modifier;
        }
    }
}
