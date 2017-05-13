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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // UseSound
            // 
            resources.ApplyResources(this.UseSound, "UseSound");
            this.UseSound.Name = "UseSound";
            this.UseSound.UseVisualStyleBackColor = true;
            // 
            // UseShortcut
            // 
            resources.ApplyResources(this.UseShortcut, "UseShortcut");
            this.UseShortcut.Name = "UseShortcut";
            this.UseShortcut.UseVisualStyleBackColor = true;
            this.UseShortcut.CheckedChanged += new System.EventHandler(this.UseShortcut_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // UseCtrl
            // 
            resources.ApplyResources(this.UseCtrl, "UseCtrl");
            this.UseCtrl.Name = "UseCtrl";
            this.UseCtrl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // UseAlt
            // 
            resources.ApplyResources(this.UseAlt, "UseAlt");
            this.UseAlt.Name = "UseAlt";
            this.UseAlt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // UseShift
            // 
            resources.ApplyResources(this.UseShift, "UseShift");
            this.UseShift.Name = "UseShift";
            this.UseShift.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Shortcut
            // 
            resources.ApplyResources(this.Shortcut, "Shortcut");
            this.Shortcut.Name = "Shortcut";
            this.Shortcut.ReadOnly = true;
            // 
            // GetKeyButton
            // 
            resources.ApplyResources(this.GetKeyButton, "GetKeyButton");
            this.GetKeyButton.Name = "GetKeyButton";
            this.GetKeyButton.UseVisualStyleBackColor = true;
            this.GetKeyButton.Click += new System.EventHandler(this.GetKeyButton_Click);
            this.GetKeyButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetKeyButton_KeyUp);
            // 
            // KeyResetButton
            // 
            resources.ApplyResources(this.KeyResetButton, "KeyResetButton");
            this.KeyResetButton.Name = "KeyResetButton";
            this.KeyResetButton.UseVisualStyleBackColor = true;
            this.KeyResetButton.Click += new System.EventHandler(this.KeyResetButton_Click);
            // 
            // KeyLabel
            // 
            resources.ApplyResources(this.KeyLabel, "KeyLabel");
            this.KeyLabel.Name = "KeyLabel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ResizePer
            // 
            resources.ApplyResources(this.ResizePer, "ResizePer");
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
            this.ResizePer.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Form4";
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