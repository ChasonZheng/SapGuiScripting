using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Application.hotkey;
using Engine.actions;
using Engine.controller;
using Engine.controller.hotkeys;
using Action = Engine.actions.Action;

namespace Application {
    public class ApplicationConfig : ActionMap {

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
                System.Diagnostics.Debug.WriteLine(exception.StackTrace);
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
    }
}