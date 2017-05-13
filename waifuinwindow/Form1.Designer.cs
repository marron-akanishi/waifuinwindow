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
            this.components = new System.ComponentModel.Container();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.capturedImage.Location = new System.Drawing.Point(12, 12);
            this.capturedImage.Name = "capturedImage";
            this.capturedImage.Size = new System.Drawing.Size(443, 257);
            this.capturedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capturedImage.TabIndex = 2;
            this.capturedImage.TabStop = false;
            // 
            // ImageCapButton
            // 
            this.ImageCapButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ImageCapButton.Location = new System.Drawing.Point(13, 388);
            this.ImageCapButton.Name = "ImageCapButton";
            this.ImageCapButton.Size = new System.Drawing.Size(106, 58);
            this.ImageCapButton.TabIndex = 3;
            this.ImageCapButton.Text = "Cap";
            this.ImageCapButton.UseVisualStyleBackColor = true;
            this.ImageCapButton.Click += new System.EventHandler(this.ImageCapButton_Click);
            // 
            // TweetButton
            // 
            this.TweetButton.Location = new System.Drawing.Point(367, 428);
            this.TweetButton.Name = "TweetButton";
            this.TweetButton.Size = new System.Drawing.Size(88, 42);
            this.TweetButton.TabIndex = 4;
            this.TweetButton.Text = "140";
            this.TweetButton.UseVisualStyleBackColor = true;
            this.TweetButton.Click += new System.EventHandler(this.TweetButton_Click);
            // 
            // TweetText
            // 
            this.TweetText.Location = new System.Drawing.Point(225, 319);
            this.TweetText.MaxLength = 140;
            this.TweetText.Multiline = true;
            this.TweetText.Name = "TweetText";
            this.TweetText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TweetText.Size = new System.Drawing.Size(230, 81);
            this.TweetText.TabIndex = 5;
            this.TweetText.TextChanged += new System.EventHandler(this.TweetText_TextChanged);
            this.TweetText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TweetText_KeyDown);
            this.TweetText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TweetText_KeyPress);
            // 
            // TopMost_Me
            // 
            this.TopMost_Me.AutoSize = true;
            this.TopMost_Me.Location = new System.Drawing.Point(13, 454);
            this.TopMost_Me.Name = "TopMost_Me";
            this.TopMost_Me.Size = new System.Drawing.Size(91, 16);
            this.TopMost_Me.TabIndex = 6;
            this.TopMost_Me.Text = "TopMost(Me)";
            this.TopMost_Me.UseVisualStyleBackColor = true;
            this.TopMost_Me.CheckedChanged += new System.EventHandler(this.TopMost_Me_CheckedChanged);
            // 
            // ImageSaveButton
            // 
            this.ImageSaveButton.Location = new System.Drawing.Point(125, 388);
            this.ImageSaveButton.Name = "ImageSaveButton";
            this.ImageSaveButton.Size = new System.Drawing.Size(95, 58);
            this.ImageSaveButton.TabIndex = 8;
            this.ImageSaveButton.Text = "Save";
            this.ImageSaveButton.UseVisualStyleBackColor = true;
            this.ImageSaveButton.Click += new System.EventHandler(this.ImageSaveButton_Click);
            // 
            // ModeSelect
            // 
            this.ModeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelect.FormattingEnabled = true;
            this.ModeSelect.Items.AddRange(new object[] {
            "DeviceContext",
            "WindowArea",
            "SelectArea"});
            this.ModeSelect.Location = new System.Drawing.Point(13, 360);
            this.ModeSelect.Name = "ModeSelect";
            this.ModeSelect.Size = new System.Drawing.Size(207, 20);
            this.ModeSelect.TabIndex = 9;
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(11, 336);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(152, 12);
            this.AreaLabel.TabIndex = 10;
            this.AreaLabel.Text = "X:9999 Y:9999 W:9999 H:9999";
            this.AreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AreaSelButton
            // 
            this.AreaSelButton.Location = new System.Drawing.Point(165, 331);
            this.AreaSelButton.Name = "AreaSelButton";
            this.AreaSelButton.Size = new System.Drawing.Size(55, 23);
            this.AreaSelButton.TabIndex = 11;
            this.AreaSelButton.Text = "Sel";
            this.AreaSelButton.UseVisualStyleBackColor = true;
            this.AreaSelButton.Click += new System.EventHandler(this.AreaSelButton_Click);
            // 
            // Image1
            // 
            this.Image1.AutoSize = true;
            this.Image1.Location = new System.Drawing.Point(225, 432);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(30, 16);
            this.Image1.TabIndex = 15;
            this.Image1.Text = "1";
            this.Image1.UseVisualStyleBackColor = true;
            // 
            // Image2
            // 
            this.Image2.AutoSize = true;
            this.Image2.Location = new System.Drawing.Point(261, 432);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(30, 16);
            this.Image2.TabIndex = 16;
            this.Image2.Text = "2";
            this.Image2.UseVisualStyleBackColor = true;
            // 
            // Image3
            // 
            this.Image3.AutoSize = true;
            this.Image3.Location = new System.Drawing.Point(297, 432);
            this.Image3.Name = "Image3";
            this.Image3.Size = new System.Drawing.Size(30, 16);
            this.Image3.TabIndex = 17;
            this.Image3.Text = "3";
            this.Image3.UseVisualStyleBackColor = true;
            // 
            // Image4
            // 
            this.Image4.AutoSize = true;
            this.Image4.Location = new System.Drawing.Point(331, 432);
            this.Image4.Name = "Image4";
            this.Image4.Size = new System.Drawing.Size(30, 16);
            this.Image4.TabIndex = 18;
            this.Image4.Text = "4";
            this.Image4.UseVisualStyleBackColor = true;
            // 
            // Screen1
            // 
            this.Screen1.AutoSize = true;
            this.Screen1.Checked = true;
            this.Screen1.Location = new System.Drawing.Point(227, 297);
            this.Screen1.Name = "Screen1";
            this.Screen1.Size = new System.Drawing.Size(29, 16);
            this.Screen1.TabIndex = 19;
            this.Screen1.TabStop = true;
            this.Screen1.Text = "1";
            this.Screen1.UseVisualStyleBackColor = true;
            this.Screen1.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // Screen2
            // 
            this.Screen2.AutoSize = true;
            this.Screen2.Location = new System.Drawing.Point(262, 297);
            this.Screen2.Name = "Screen2";
            this.Screen2.Size = new System.Drawing.Size(29, 16);
            this.Screen2.TabIndex = 20;
            this.Screen2.Text = "2";
            this.Screen2.UseVisualStyleBackColor = true;
            this.Screen2.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // Screen3
            // 
            this.Screen3.AutoSize = true;
            this.Screen3.Location = new System.Drawing.Point(298, 297);
            this.Screen3.Name = "Screen3";
            this.Screen3.Size = new System.Drawing.Size(29, 16);
            this.Screen3.TabIndex = 21;
            this.Screen3.Text = "3";
            this.Screen3.UseVisualStyleBackColor = true;
            this.Screen3.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // Screen4
            // 
            this.Screen4.AutoSize = true;
            this.Screen4.Location = new System.Drawing.Point(332, 297);
            this.Screen4.Name = "Screen4";
            this.Screen4.Size = new System.Drawing.Size(29, 16);
            this.Screen4.TabIndex = 22;
            this.Screen4.Text = "4";
            this.Screen4.UseVisualStyleBackColor = true;
            this.Screen4.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "CapturedScreen";
            // 
            // FooterMode
            // 
            this.FooterMode.AutoSize = true;
            this.FooterMode.Location = new System.Drawing.Point(225, 408);
            this.FooterMode.Name = "FooterMode";
            this.FooterMode.Size = new System.Drawing.Size(60, 16);
            this.FooterMode.TabIndex = 25;
            this.FooterMode.Text = "footer：";
            this.FooterMode.UseVisualStyleBackColor = true;
            this.FooterMode.CheckedChanged += new System.EventHandler(this.TweetText_TextChanged);
            // 
            // FooterText
            // 
            this.FooterText.Location = new System.Drawing.Point(282, 406);
            this.FooterText.Name = "FooterText";
            this.FooterText.Size = new System.Drawing.Size(172, 19);
            this.FooterText.TabIndex = 26;
            this.FooterText.TextChanged += new System.EventHandler(this.TweetText_TextChanged);
            // 
            // TopMost_Target
            // 
            this.TopMost_Target.AutoSize = true;
            this.TopMost_Target.Location = new System.Drawing.Point(110, 454);
            this.TopMost_Target.Name = "TopMost_Target";
            this.TopMost_Target.Size = new System.Drawing.Size(109, 16);
            this.TopMost_Target.TabIndex = 27;
            this.TopMost_Target.Text = "TopMost(Target)";
            this.TopMost_Target.UseVisualStyleBackColor = true;
            this.TopMost_Target.CheckedChanged += new System.EventHandler(this.TopMost_Target_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.TweetStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(467, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.StatusLabel1.Text = "準備完了";
            // 
            // TweetStatus
            // 
            this.TweetStatus.Name = "TweetStatus";
            this.TweetStatus.Size = new System.Drawing.Size(397, 17);
            this.TweetStatus.Spring = true;
            this.TweetStatus.Text = "認証済み";
            this.TweetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResizeMode
            // 
            this.ResizeMode.AutoSize = true;
            this.ResizeMode.BackColor = System.Drawing.SystemColors.Control;
            this.ResizeMode.Location = new System.Drawing.Point(225, 454);
            this.ResizeMode.Name = "ResizeMode";
            this.ResizeMode.Size = new System.Drawing.Size(92, 16);
            this.ResizeMode.TabIndex = 29;
            this.ResizeMode.Text = "Resize Image";
            this.ResizeMode.UseVisualStyleBackColor = false;
            // 
            // exeSetButton
            // 
            this.exeSetButton.Location = new System.Drawing.Point(125, 303);
            this.exeSetButton.Name = "exeSetButton";
            this.exeSetButton.Size = new System.Drawing.Size(94, 23);
            this.exeSetButton.TabIndex = 1;
            this.exeSetButton.Text = "Set";
            this.exeSetButton.UseVisualStyleBackColor = true;
            this.exeSetButton.Click += new System.EventHandler(this.exeSetButton_Click);
            // 
            // exeName
            // 
            this.exeName.FormattingEnabled = true;
            this.exeName.Location = new System.Drawing.Point(13, 277);
            this.exeName.Name = "exeName";
            this.exeName.Size = new System.Drawing.Size(206, 20);
            this.exeName.TabIndex = 30;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(13, 303);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(106, 23);
            this.UpdateButton.TabIndex = 31;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(367, 280);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(2);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(86, 32);
            this.SettingButton.TabIndex = 32;
            this.SettingButton.Text = "Setting";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 499);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WaifuInWindow";
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
        private System.Windows.Forms.Timer timer1;
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
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TweetStatus;
        private System.Windows.Forms.CheckBox ResizeMode;
        private System.Windows.Forms.Button exeSetButton;
        private System.Windows.Forms.ComboBox exeName;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SettingButton;
    }
}

