﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waifuinwindow {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void UseShortcut_CheckedChanged(object sender, EventArgs e) {
            this.UseCtrl.Enabled = this.UseShortcut.Checked;
            this.UseAlt.Enabled = this.UseShortcut.Checked;
            this.UseShift.Enabled = this.UseShortcut.Checked;
            this.Shortcut.Enabled = this.UseShortcut.Checked;
        }

        private void Form4_Load(object sender, EventArgs e) {
            this.UseSound.Checked = ((Form1)this.Owner).MainIni.UseSound;
            this.UseShortcut.Checked = ((Form1)this.Owner).MainIni.UseShortcut;
            this.UseAlt.Checked = ((Form1)this.Owner).MainIni.UseAlt;
            this.UseCtrl.Checked = ((Form1)this.Owner).MainIni.UseCtrl;
            this.UseShift.Checked = ((Form1)this.Owner).MainIni.UseShift;
            this.Shortcut.Text = ((Form1)this.Owner).MainIni.ShortcutKey;
        }

        private void OkButton_Click(object sender, EventArgs e) {
            ((Form1)this.Owner).MainIni.UseSound = this.UseSound.Checked;
            ((Form1)this.Owner).MainIni.UseShortcut = this.UseShortcut.Checked;
            ((Form1)this.Owner).MainIni.UseAlt = this.UseAlt.Checked;
            ((Form1)this.Owner).MainIni.UseCtrl = this.UseCtrl.Checked;
            ((Form1)this.Owner).MainIni.UseShift = this.UseShift.Checked;
            ((Form1)this.Owner).MainIni.ShortcutKey = this.Shortcut.Text;
            this.Close();
        }
    }
}
