﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SapGuiScripting.actions;
using SapGuiScripting.@base;

namespace HelloWorld {


    [System.Flags]
    public enum ModifierKeys : uint {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }
    public partial class Form1 : Form {

        KeyboardHook hook = new KeyboardHook();

        public Form1() {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(Hook_KeyPressed);
            //ALT+F12
            hook.RegisterHotKey(HelloWorld.ModifierKeys.Alt, Keys.F12);
        }

        void Hook_KeyPressed(object sender, KeyPressedEventArgs e) {
            label1.Text = e.Modifier.ToString() + " + " + e.Key.ToString();
            ActiveSessionProvider provider = new ActiveSessionProvider();

            InputSetTextAction action = new InputSetTextAction();
            action.Execute(provider.GetSession());
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}