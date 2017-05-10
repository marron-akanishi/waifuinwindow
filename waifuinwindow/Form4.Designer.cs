namespace waifuinwindow {
    partial class Form4 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.UseSound = new System.Windows.Forms.CheckBox();
            this.UseShortcut = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UseCtrl = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UseAlt = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UseShift = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Shortcut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(345, 175);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(119, 35);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(215, 175);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(119, 35);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // UseSound
            // 
            this.UseSound.AutoSize = true;
            this.UseSound.Location = new System.Drawing.Point(12, 12);
            this.UseSound.Name = "UseSound";
            this.UseSound.Size = new System.Drawing.Size(167, 21);
            this.UseSound.TabIndex = 2;
            this.UseSound.Text = "撮影時に音を鳴らす";
            this.UseSound.UseVisualStyleBackColor = true;
            // 
            // UseShortcut
            // 
            this.UseShortcut.AutoSize = true;
            this.UseShortcut.Location = new System.Drawing.Point(12, 39);
            this.UseShortcut.Name = "UseShortcut";
            this.UseShortcut.Size = new System.Drawing.Size(284, 21);
            this.UseShortcut.TabIndex = 3;
            this.UseShortcut.Text = "Capボタンのショートカットを有効化する";
            this.UseShortcut.UseVisualStyleBackColor = true;
            this.UseShortcut.CheckedChanged += new System.EventHandler(this.UseShortcut_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "L";
            // 
            // UseCtrl
            // 
            this.UseCtrl.AutoSize = true;
            this.UseCtrl.Enabled = false;
            this.UseCtrl.Location = new System.Drawing.Point(68, 66);
            this.UseCtrl.Name = "UseCtrl";
            this.UseCtrl.Size = new System.Drawing.Size(57, 21);
            this.UseCtrl.TabIndex = 5;
            this.UseCtrl.Text = "Ctrl";
            this.UseCtrl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "+";
            // 
            // UseAlt
            // 
            this.UseAlt.AutoSize = true;
            this.UseAlt.Enabled = false;
            this.UseAlt.Location = new System.Drawing.Point(144, 66);
            this.UseAlt.Name = "UseAlt";
            this.UseAlt.Size = new System.Drawing.Size(51, 21);
            this.UseAlt.TabIndex = 7;
            this.UseAlt.Text = "Alt";
            this.UseAlt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "+";
            // 
            // UseShift
            // 
            this.UseShift.AutoSize = true;
            this.UseShift.Enabled = false;
            this.UseShift.Location = new System.Drawing.Point(215, 66);
            this.UseShift.Name = "UseShift";
            this.UseShift.Size = new System.Drawing.Size(64, 21);
            this.UseShift.TabIndex = 9;
            this.UseShift.Text = "Shift";
            this.UseShift.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "+";
            // 
            // Shortcut
            // 
            this.Shortcut.Enabled = false;
            this.Shortcut.Location = new System.Drawing.Point(302, 64);
            this.Shortcut.Name = "Shortcut";
            this.Shortcut.Size = new System.Drawing.Size(100, 24);
            this.Shortcut.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 222);
            this.Controls.Add(this.Shortcut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UseShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UseAlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UseCtrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UseShortcut);
            this.Controls.Add(this.UseSound);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.CheckBox UseSound;
        private System.Windows.Forms.CheckBox UseShortcut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox UseCtrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UseAlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox UseShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Shortcut;
    }
}