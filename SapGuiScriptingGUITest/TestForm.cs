using System;
using System.Windows.Forms;
using SapGuiHotkeysApplication.hotkey;
using SapGuiScripting.actions;
using SapGuiScripting.session;
using Action = SapGuiScripting.actions.Action;

namespace SapGuiScriptingGUITest {
    public partial class TestForm : Form, ActionContext {
        private readonly Action actionToTest;
        private readonly KeyboardHook hook = new KeyboardHook();


        public TestForm(Action action) {
            InitializeComponent();
            actionToTest = action;

            // register the event that is fired after the key press.
            hook.KeyPressed += Hook_KeyPressed;
            //CTRL+F12
            hook.RegisterHotKey(SapGuiHotkeysApplication.hotkey.ModifierKeys.Control, Keys.F12);
        }

        public GuiSession GetSession() {
            ActiveSessionProvider provider = new ActiveSessionProvider();
            return provider.GetSession();
        }

        private void TestForm_Load(object sender, EventArgs e) {
        }

        private void Hook_KeyPressed(object sender, KeyPressedEventArgs e) {
            try {
                actionToTest.Execute(this);
            }
            catch (Exception) {
                System.Diagnostics.Debug.WriteLine("Action failed");
            }
        }
    }
}