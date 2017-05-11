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
            this.GetKeyButton = new System.Windows.Forms.Button();
            this.KeyResetButton = new System.Windows.Forms.Button();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResizePer = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResizePer)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(230, 124);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(79, 25);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(143, 124);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(79, 25);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // UseSound
            // 
            this.UseSound.AutoSize = true;
            this.UseSound.Location = new System.Drawing.Point(8, 8);
            this.UseSound.Margin = new System.Windows.Forms.Padding(2);
            this.UseSound.Name = "UseSound";
            this.UseSound.Size = new System.Drawing.Size(120, 16);
            this.UseSound.TabIndex = 2;
            this.UseSound.Text = "撮影時に音を鳴らす";
            this.UseSound.UseVisualStyleBackColor = true;
            // 
            // UseShortcut
            // 
            this.UseShortcut.AutoSize = true;
            this.UseShortcut.Location = new System.Drawing.Point(8, 28);
            this.UseShortcut.Margin = new System.Windows.Forms.Padding(2);
            this.UseShortcut.Name = "UseShortcut";
            this.UseShortcut.Size = new System.Drawing.Size(203, 16);
            this.UseShortcut.TabIndex = 3;
            this.UseShortcut.Text = "Capボタンのショートカットを有効化する";
            this.UseShortcut.UseVisualStyleBackColor = true;
            this.UseShortcut.CheckedChanged += new System.EventHandler(this.UseShortcut_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "L";
            // 
            // UseCtrl
            // 
            this.UseCtrl.AutoSize = true;
            this.UseCtrl.Enabled = false;
            this.UseCtrl.Location = new System.Drawing.Point(45, 47);
            this.UseCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.UseCtrl.Name = "UseCtrl";
            this.UseCtrl.Size = new System.Drawing.Size(43, 16);
            this.UseCtrl.TabIndex = 5;
            this.UseCtrl.Text = "Ctrl";
            this.UseCtrl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "+";
            // 
            // UseAlt
            // 
            this.UseAlt.AutoSize = true;
            this.UseAlt.Enabled = false;
            this.UseAlt.Location = new System.Drawing.Point(96, 47);
            this.UseAlt.Margin = new System.Windows.Forms.Padding(2);
            this.UseAlt.Name = "UseAlt";
            this.UseAlt.Size = new System.Drawing.Size(39, 16);
            this.UseAlt.TabIndex = 7;
            this.UseAlt.Text = "Alt";
            this.UseAlt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "+";
            // 
            // UseShift
            // 
            this.UseShift.AutoSize = true;
            this.UseShift.Enabled = false;
            this.UseShift.Location = new System.Drawing.Point(143, 47);
            this.UseShift.Margin = new System.Windows.Forms.Padding(2);
            this.UseShift.Name = "UseShift";
            this.UseShift.Size = new System.Drawing.Size(48, 16);
            this.UseShift.TabIndex = 9;
            this.UseShift.Text = "Shift";
            this.UseShift.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "+";
            // 
            // Shortcut
            // 
            this.Shortcut.Enabled = false;
            this.Shortcut.Location = new System.Drawing.Point(201, 45);
            this.Shortcut.Margin = new System.Windows.Forms.Padding(2);
            this.Shortcut.Name = "Shortcut";
            this.Shortcut.ReadOnly = true;
            this.Shortcut.Size = new System.Drawing.Size(68, 19);
            this.Shortcut.TabIndex = 11;
            // 
            // GetKeyButton
            // 
            this.GetKeyButton.Location = new System.Drawing.Point(201, 69);
            this.GetKeyButton.Name = "GetKeyButton";
            this.GetKeyButton.Size = new System.Drawing.Size(47, 23);
            this.GetKeyButton.TabIndex = 12;
            this.GetKeyButton.Text = "Set";
            this.GetKeyButton.UseVisualStyleBackColor = true;
            this.GetKeyButton.Click += new System.EventHandler(this.GetKeyButton_Click);
            this.GetKeyButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetKeyButton_KeyUp);
            // 
            // KeyResetButton
            // 
            this.KeyResetButton.Location = new System.Drawing.Point(254, 69);
            this.KeyResetButton.Name = "KeyResetButton";
            this.KeyResetButton.Size = new System.Drawing.Size(47, 23);
            this.KeyResetButton.TabIndex = 13;
            this.KeyResetButton.Text = "Reset";
            this.KeyResetButton.UseVisualStyleBackColor = true;
            this.KeyResetButton.Click += new System.EventHandler(this.KeyResetButton_Click);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(156, 95);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(145, 12);
            this.KeyLabel.TabIndex = 14;
            this.KeyLabel.Text = "キー認識中(Escでキャンセル)";
            this.KeyLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "リサイズ% (25～75)";
            // 
            // ResizePer
            // 
            this.ResizePer.Location = new System.Drawing.Point(8, 89);
            this.ResizePer.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.ResizePer.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ResizePer.Name = "ResizePer";
            this.ResizePer.Size = new System.Drawing.Size(44, 19);
            this.ResizePer.TabIndex = 16;
            this.ResizePer.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "%";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 157);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResizePer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeyResetButton);
            this.Controls.Add(this.GetKeyButton);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResizePer)).EndInit();
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
        private System.Windows.Forms.Button GetKeyButton;
        private System.Windows.Forms.Button KeyResetButton;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ResizePer;
        private System.Windows.Forms.Label label6;
    }
}