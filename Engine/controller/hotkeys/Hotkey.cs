using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Engine.controller.hotkeys {

    public class Hotkey {

        private ModifierKeys[] modifiers { get; set; }
        private Keys key { get; set; }

        public Hotkey(Keys key, params ModifierKeys[] modifiers) {
            this.modifiers = modifiers;
            this.key = key;
        }

        public Hotkey() {
            //needed for serilization to use in settings
        }

        public uint GetKeyUInt() {
            return (uint)key;
        }

        public uint GetModifiersUInt() {
            uint result = 0;
            bool first = true;
            foreach (var modifier in modifiers) {
                if (first) {
                    first = false;
                    result = (uint)modifier;
                    continue;
                }
                result = result | (uint)modifier;
            }
            return result;
        }

        public override string ToString() {
            string result = "";
            foreach (var modifier in modifiers) {
                result += modifier + "+";
            }
            result += key;
            return result;
        }



        public override int GetHashCode() {
            List<System.TypeCode> list = new List<System.TypeCode>();

            foreach (var modifier in modifiers) {
                list.Add(modifier.GetTypeCode());
            }
            list.Add(key.GetTypeCode());
            int hash = 0;
            foreach (var element in list) {
                hash = unchecked(hash +
                    EqualityComparer<System.TypeCode>.Default.GetHashCode(element));
            }
            return hash;
        }

        public override bool Equals(object obj) {
            return Equals(obj as Hotkey);
        }

        public bool Equals(Hotkey hotkey) {
            return hotkey.GetHashCode() == GetHashCode();
            // return hotkey != null && hotkey.key == this.key && hotkey.modifiers == this.modifiers;
        }
    }
}
