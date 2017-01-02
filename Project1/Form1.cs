using System;
using System.Windows.Forms;
using SapGuiHotkeysApplication.hotkey;
using SapGuiScripting.session;

namespace SapGuiHotkeysApplication {
    public partial class Form1 : Form {
        private readonly KeyboardHook hook = new KeyboardHook();

        public Form1() {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook.KeyPressed += Hook_KeyPressed;
            //ALT+F12
            hook.RegisterHotKey(hotkey.ModifierKeys.Alt, Keys.F12);
        }

        private void Hook_KeyPressed(object sender, KeyPressedEventArgs e) {
            label1.Text = e.Modifier + " + " + e.Key;
            ActiveSessionProvider provider = new ActiveSessionProvider();

            //InputSetTextAction action = new InputSetTextAction();
            //action.Execute(provider.GetSession());
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }
    }
}