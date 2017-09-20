using System.Windows.Forms;

namespace Engine.controller.hotkeys
{
    public class Hotkey {
        private readonly ModifierKeys modifier;
        private readonly Keys key;


        public Hotkey(ModifierKeys modifier, Keys key)
        {
            this.modifier = modifier;
            this.key = key;

        }
    }
}
