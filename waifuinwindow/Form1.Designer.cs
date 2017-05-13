namespace waifuinwindow {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.capturedImage = new System.Windows.Forms.PictureBox();
            this.ImageCapButton = new System.Windows.Forms.Button();
            this.TweetButton = new System.Windows.Forms.Button();
            this.TweetText = new System.Windows.Forms.TextBox();
            this.TopMost_Me = new System.Windows.Forms.CheckBox();
            this.ImageSaveButton = new System.Windows.Forms.Button();
            this.ModeSelect = new System.Windows.Forms.ComboBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.AreaSelButton = new System.Windows.Forms.Button();
            this.Image1 = new System.Windows.Forms.CheckBox();
            this.Image2 = new System.Windows.Forms.CheckBox();
            this.Image3 = new System.Windows.Forms.CheckBox();
            this.Image4 = new System.Windows.Forms.CheckBox();
            this.Screen1 = new System.Windows.Forms.RadioButton();
            this.Screen2 = new System.Windows.Forms.RadioButton();
            this.Screen3 = new System.Windows.Forms.RadioButton();
            this.Screen4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.FooterMode = new System.Windows.Forms.CheckBox();
            this.FooterText = new System.Windows.Forms.TextBox();
            this.TopMost_Target = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TweetStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ResizeMode = new System.Windows.Forms.CheckBox();
            this.exeSetButton = new System.Windows.Forms.Button();
            this.exeName = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capturedImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // capturedImage
            // 
            resources.ApplyResources(this.capturedImage, "capturedImage");
            this.capturedImage.Name = "capturedImage";
            this.capturedImage.TabStop = false;
            // 
            // ImageCapButton
            // 
            resources.ApplyResources(this.ImageCapButton, "ImageCapButton");
            this.ImageCapButton.Name = "ImageCapButton";
            this.ImageCapButton.UseVisualStyleBackColor = true;
            this.ImageCapButton.Click += new System.EventHandler(this.ImageCapButton_Click);
            // 
            // TweetButton
            // 
            resources.ApplyResources(this.TweetButton, "TweetButton");
            this.TweetButton.Name = "TweetButton";
            this.TweetButton.UseVisualStyleBackColor = true;
            this.TweetButton.Click += new System.EventHandler(this.TweetButton_Click);
            // 
            // TweetText
            // 
            resources.ApplyResources(this.TweetText, "TweetText");
            this.TweetText.Name = "TweetText";
            this.TweetText.TextChanged += new System.EventHandler(this.TweetText_TextChanged);
            this.TweetText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TweetText_KeyDown);
            this.TweetText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TweetText_KeyPress);
            // 
            // TopMost_Me
            // 
            resources.ApplyResources(this.TopMost_Me, "TopMost_Me");
            this.TopMost_Me.Name = "TopMost_Me";
            this.TopMost_Me.UseVisualStyleBackColor = true;
            this.TopMost_Me.CheckedChanged += new System.EventHandler(this.TopMost_Me_CheckedChanged);
            // 
            // ImageSaveButton
            // 
            resources.ApplyResources(this.ImageSaveButton, "ImageSaveButton");
            this.ImageSaveButton.Name = "ImageSaveButton";
            this.ImageSaveButton.UseVisualStyleBackColor = true;
            this.ImageSaveButton.Click += new System.EventHandler(this.ImageSaveButton_Click);
            // 
            // ModeSelect
            // 
            resources.ApplyResources(this.ModeSelect, "ModeSelect");
            this.ModeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelect.FormattingEnabled = true;
            this.ModeSelect.Items.AddRange(new object[] {
            resources.GetString("ModeSelect.Items"),
            resources.GetString("ModeSelect.Items1"),
            resources.GetString("ModeSelect.Items2")});
            this.ModeSelect.Name = "ModeSelect";
            // 
            // AreaLabel
            // 
            resources.ApplyResources(this.AreaLabel, "AreaLabel");
            this.AreaLabel.Name = "AreaLabel";
            // 
            // AreaSelButton
            // 
            resources.ApplyResources(this.AreaSelButton, "AreaSelButton");
            this.AreaSelButton.Name = "AreaSelButton";
            this.AreaSelButton.UseVisualStyleBackColor = true;
            this.AreaSelButton.Click += new System.EventHandler(this.AreaSelButton_Click);
            // 
            // Image1
            // 
            resources.ApplyResources(this.Image1, "Image1");
            this.Image1.Name = "Image1";
            this.Image1.UseVisualStyleBackColor = true;
            // 
            // Image2
            // 
            resources.ApplyResources(this.Image2, "Image2");
            this.Image2.Name = "Image2";
            this.Image2.UseVisualStyleBackColor = true;
            // 
            // Image3
            // 
            resources.ApplyResources(this.Image3, "Image3");
            this.Image3.Name = "Image3";
            this.Image3.UseVisualStyleBackColor = true;
            // 
            // Image4
            // 
            resources.ApplyResources(this.Image4, "Image4");
            this.Image4.Name = "Image4";
            this.Image4.UseVisualStyleBackColor = true;
            // 
            // Screen1
            // 
            resources.ApplyResources(this.Screen1, "Screen1");
            this.Screen1.Checked = true;
            this.Screen1.Name = "Screen1";
            this.Screen1.TabStop = true;
            this.Screen1.UseVisualStyleBackColor = true;
            this.Screen1.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // Screen2
            // 
            resources.ApplyResources(this.Screen2, "Screen2");
            this.Screen2.Name = "Screen2";
            this.Screen2.UseVisualStyleBackColor = true;
            this.Screen2.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // Screen3
            // 
            resources.ApplyResources(this.Screen3, "Screen3");
            this.Screen3.Name = "Screen3";
            this.Screen3.UseVisualStyleBackColor = true;
            this.Screen3.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // Screen4
            // 
            resources.ApplyResources(this.Screen4, "Screen4");
            this.Screen4.Name = "Screen4";
            this.Screen4.UseVisualStyleBackColor = true;
            this.Screen4.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // FooterMode
            // 
            resources.ApplyResources(this.FooterMode, "FooterMode");
            this.FooterMode.Name = "FooterMode";
            this.FooterMode.UseVisualStyleBackColor = true;
            this.FooterMode.CheckedChanged += new System.EventHandler(this.TweetText_TextChanged);
            // 
            // FooterText
            // 
            resources.ApplyResources(this.FooterText, "FooterText");
            this.FooterText.Name = "FooterText";
            this.FooterText.TextChanged += new System.EventHandler(this.TweetText_TextChanged);
            // 
            // TopMost_Target
            // 
            resources.ApplyResources(this.TopMost_Target, "TopMost_Target");
            this.TopMost_Target.Name = "TopMost_Target";
            this.TopMost_Target.UseVisualStyleBackColor = true;
            this.TopMost_Target.CheckedChanged += new System.EventHandler(this.TopMost_Target_CheckedChanged);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.TweetStatus});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // StatusLabel
            // 
            resources.ApplyResources(this.StatusLabel, "StatusLabel");
            this.StatusLabel.Name = "StatusLabel";
            // 
            // TweetStatus
            // 
            resources.ApplyResources(this.TweetStatus, "TweetStatus");
            this.TweetStatus.Name = "TweetStatus";
            this.TweetStatus.Spring = true;
            // 
            // ResizeMode
            // 
            resources.ApplyResources(this.ResizeMode, "ResizeMode");
            this.ResizeMode.BackColor = System.Drawing.SystemColors.Control;
            this.ResizeMode.Name = "ResizeMode";
            this.ResizeMode.UseVisualStyleBackColor = false;
            // 
            // exeSetButton
            // 
            resources.ApplyResources(this.exeSetButton, "exeSetButton");
            this.exeSetButton.Name = "exeSetButton";
            this.exeSetButton.UseVisualStyleBackColor = true;
            this.exeSetButton.Click += new System.EventHandler(this.exeSetButton_Click);
            // 
            // exeName
            // 
            resources.ApplyResources(this.exeName, "exeName");
            this.exeName.FormattingEnabled = true;
            this.exeName.Name = "exeName";
            // 
            // UpdateButton
            // 
            resources.ApplyResources(this.UpdateButton, "UpdateButton");
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SettingButton
            // 
            resources.ApplyResources(this.SettingButton, "SettingButton");
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.exeName);
            this.Controls.Add(this.ResizeMode);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TopMost_Target);
            this.Controls.Add(this.FooterText);
            this.Controls.Add(this.FooterMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Screen4);
            this.Controls.Add(this.Screen3);
            this.Controls.Add(this.Screen2);
            this.Controls.Add(this.Screen1);
            this.Controls.Add(this.Image4);
            this.Controls.Add(this.Image3);
            this.Controls.Add(this.Image2);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.AreaSelButton);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.ModeSelect);
            this.Controls.Add(this.ImageSaveButton);
            this.Controls.Add(this.TopMost_Me);
            this.Controls.Add(this.TweetText);
            this.Controls.Add(this.TweetButton);
            this.Controls.Add(this.ImageCapButton);
            this.Controls.Add(this.capturedImage);
            this.Controls.Add(this.exeSetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.capturedImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox capturedImage;
        private System.Windows.Forms.Button ImageCapButton;
        private System.Windows.Forms.Button TweetButton;
        private System.Windows.Forms.TextBox TweetText;
        private System.Windows.Forms.CheckBox TopMost_Me;
        private System.Windows.Forms.Button ImageSaveButton;
        private System.Windows.Forms.ComboBox ModeSelect;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Button AreaSelButton;
        private System.Windows.Forms.CheckBox Image1;
        private System.Windows.Forms.CheckBox Image2;
        private System.Windows.Forms.CheckBox Image3;
        private System.Windows.Forms.CheckBox Image4;
        private System.Windows.Forms.RadioButton Screen1;
        private System.Windows.Forms.RadioButton Screen2;
        private System.Windows.Forms.RadioButton Screen3;
        private System.Windows.Forms.RadioButton Screen4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox FooterMode;
        private System.Windows.Forms.TextBox FooterText;
        private System.Windows.Forms.CheckBox TopMost_Target;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TweetStatus;
        private System.Windows.Forms.CheckBox ResizeMode;
        private System.Windows.Forms.Button exeSetButton;
        private System.Windows.Forms.ComboBox exeName;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SettingButton;
    }
}

