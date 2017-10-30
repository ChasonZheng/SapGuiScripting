using Engine.controller.hotkeys;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Application.ui.config {
    partial class HotkeyControlcs {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public Hotkey CreateHotkey() {
            List<ModifierKeys> modifiers = new List<ModifierKeys>();
            if (controlBox.Checked)
                modifiers.Add(Engine.controller.hotkeys.ModifierKeys.Control);
            if (shiftBox.Checked)
                modifiers.Add(Engine.controller.hotkeys.ModifierKeys.Shift);
            if (altBox.Checked)
                modifiers.Add(Engine.controller.hotkeys.ModifierKeys.Alt);

            Keys key;
            Enum.TryParse<Keys>(keys.SelectedValue.ToString(), out key);
            return new Hotkey(key, modifiers.ToArray());
        }

        #region Vom Komponenten-Deseiner generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.controlBox = new System.Windows.Forms.CheckBox();
            this.shiftBox = new System.Windows.Forms.CheckBox();
            this.altBox = new System.Windows.Forms.CheckBox();
            this.keys = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.AutoSize = true;
            this.controlBox.Location = new System.Drawing.Point(6, 14);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(54, 17);
            this.controlBox.TabIndex = 0;
            this.controlBox.Text = "CTRL";
            this.controlBox.UseVisualStyleBackColor = true;
            this.controlBox.CheckedChanged += new System.EventHandler(this.controlBox_CheckedChanged);
            // 
            // shiftBox
            // 
            this.shiftBox.AutoSize = true;
            this.shiftBox.Location = new System.Drawing.Point(66, 14);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(57, 17);
            this.shiftBox.TabIndex = 1;
            this.shiftBox.Text = "SHIFT";
            this.shiftBox.UseVisualStyleBackColor = true;
            this.shiftBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // altBox
            // 
            this.altBox.AutoSize = true;
            this.altBox.Location = new System.Drawing.Point(126, 14);
            this.altBox.Name = "altBox";
            this.altBox.Size = new System.Drawing.Size(46, 17);
            this.altBox.TabIndex = 2;
            this.altBox.Text = "ALT";
            this.altBox.UseVisualStyleBackColor = true;
            this.altBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // keys
            // 
            this.keys.FormattingEnabled = true;
            this.keys.Location = new System.Drawing.Point(218, 12);
            this.keys.Name = "keys";
            this.keys.Size = new System.Drawing.Size(121, 21);
            this.keys.TabIndex = 3;
            this.keys.Text = "Key";
            this.keys.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HotkeyControlcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.keys);
            this.Controls.Add(this.altBox);
            this.Controls.Add(this.shiftBox);
            this.Controls.Add(this.controlBox);
            this.Name = "HotkeyControlcs";
            this.Size = new System.Drawing.Size(349, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            keys.DataSource = Enum.GetValues(typeof(ModifierKeys));
        }

        private System.Windows.Forms.CheckBox controlBox;
        private System.Windows.Forms.CheckBox shiftBox;
        private System.Windows.Forms.CheckBox altBox;
        private System.Windows.Forms.ComboBox keys;
    }
}
