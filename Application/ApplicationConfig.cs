using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Application.hotkey;
using Engine.actions;
using Action = Engine.actions.Action;

namespace Application {
    public class ApplicationConfig {
        private struct Hotkey {
            private readonly ModifierKeys modifier;
            private readonly Keys key;


            public Hotkey(ModifierKeys modifier, Keys key) {
                this.modifier = modifier;
                this.key = key;

            }
        }

        private Form1 mainForm;
        private readonly ActionContext context = new ActiveActionContext();

        private Dictionary<Hotkey, Action> actions = new Dictionary<Hotkey, Action>();
        private readonly KeyboardHook hook = new KeyboardHook();

        public void RegisterOnHotKey(Action action, ModifierKeys modifier, Keys key) {

            //Save action
            Hotkey hotkey = new Hotkey(modifier, key);
            actions.Add(hotkey, action);

            //Register action
            hook.RegisterHotKey(modifier, key);
        }

        private void Hook_KeyPressed(object sender, KeyPressedEventArgs e) {
            Hotkey hotkey = new Hotkey(e.Modifier, e.Key);
            Action action = actions[hotkey];
            if (action == null) return;
            try {
                action.Execute(context);
            } catch (Exception exception) {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }

        public void Start() {
            mainForm = new Form1();
            hook.KeyPressed += Hook_KeyPressed;
            //Application.
        }

    }
}