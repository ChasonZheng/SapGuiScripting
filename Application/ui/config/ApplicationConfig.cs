using Application.hotkey;
using Engine.actions;
using Engine.controller;
using Engine.controller.hotkeys;
using System;
using System.Collections.Generic;
using Action = Engine.actions.Action;

namespace Application.ui.config {
    public class ApplicationConfig : ActionMap {

        private Form1 mainForm;
        private readonly ActionContext context = new ActiveActionContext();

        private Dictionary<Hotkey, Action> actions = new Dictionary<Hotkey, Action>();
        private readonly KeyboardHook hook = new KeyboardHook();

        public void RegisterOnHotKey(Action action, Hotkey hotkey) {

            actions.Add(hotkey, action);

            //Register action
            hook.RegisterHotKey(hotkey);
            Console.WriteLine("Registered:" + hotkey.ToString());
        }

        private void Hook_KeyPressed(object sender, KeyPressedEventArgs e) {
            //Console.WriteLine("HK pressed" + e.Modifier + e.Key);
            Hotkey hotkey = new Hotkey(e.Key, e.Modifier);
            Console.WriteLine("HK pressed" + e.Modifier + e.Key);

            if (actions.TryGetValue(hotkey, out Action action)) {
                try {
                    action.Execute(context);
                } catch (Exception exception) {
                    System.Diagnostics.Debug.WriteLine(exception.Message);
                    System.Diagnostics.Debug.WriteLine(exception.StackTrace);
                }
            } else {

                Console.WriteLine("Keine action zu" + e.Modifier + e.Key);

                Console.WriteLine("dafür folgende" + actions.Count);
                foreach (var action2 in actions) {
                    Console.WriteLine(action2.Key.ToString());
                    Console.WriteLine(action2.Key.GetHashCode());
                    Console.WriteLine(e.Key.GetHashCode());
                    Console.WriteLine(action2.Key.Equals(e.Key));
                }
                return;
            }
        }

        public void Start() {
            mainForm = new Form1();
            hook.KeyPressed += Hook_KeyPressed;
            System.Windows.Forms.Application.Run(mainForm);
        }

        public void RegisterOnHotKey(Hotkey hotkey, Action action) {
            actions.Add(hotkey, action);
        }

        public void RegisterOnFocusChanged(FocusChangedContext context, Action action) {
            throw new NotImplementedException();
        }

        public void RegisterOnStartTransaction(NewTransactionContext context, Action action) {
            throw new NotImplementedException();
        }

        public void RegisterOnHotKey(object filteredAction, ModifierKeys control, object d) {
            //throw new NotImplementedException();
        }
    }
}