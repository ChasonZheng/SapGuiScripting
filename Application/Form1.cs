using System;
using System.Windows.Forms;
using Application.hotkey;
using System.Drawing;
using Application.ui.config;

namespace Application {
    public partial class Form1 : Form {
        private readonly KeyboardHook hook = new KeyboardHook();
        private NeinHandler handler;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;

        public Form1() {
            InitializeComponent();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.contextMenu1.MenuItems.AddRange(
                   new System.Windows.Forms.MenuItem[] { this.menuItem1 });
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Exit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            notifyIcon1.ContextMenu = this.contextMenu1;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                notifyIcon1.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
        }

        private void Hook_KeyPressed(object sender, KeyPressedEventArgs e) {
            label1.Text = e.Modifier + " + " + e.Key;

            //InputSetTextAction action = new InputSetTextAction();
            //action.Execute(provider.GetSession());
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        public void RegisterOnClick(NeinHandler neinHandler) {
            this.handler = neinHandler;
        }
        private void button1_Click(object sender, EventArgs e) {
            handler?.Handle();
            ConfigForm form = new ConfigForm();
            CheckBox box = new CheckBox();
            box.Tag = "10";
            box.Text = "a";
            box.AutoSize = true;
            box.Location = new Point(10, 50); //vertical
            form.Controls.Add(box);
            form.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void menuItem1_Click(object Sender, EventArgs e) {
            // Close the form, which closes the application.
            this.Close();
            System.Windows.Forms.Application.Exit();
            
        }
    }

    public interface NeinHandler {
        void Handle();
    }
}
