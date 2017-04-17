using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;
using System.Drawing.Imaging;

namespace waifuinwindow {
    public partial class Form1 : Form {
        WindowController.Window window;
        IniFile setting = new IniFile("./setting.ini");
        Point start, end;
        bool is_end = false;
        bool selmode = false;
        private bool keydowncalled = false;
        Bitmap[] screen = new Bitmap[4];
        string SaveDir;

        public Form1() {
            InitializeComponent();
            this.Location = new Point(int.Parse(setting.GetValue("General", "PosX", "300")), int.Parse(setting.GetValue("General", "PosY", "300")));
            if (this.Location.X >= Program.DispSize.X ||
                this.Location.Y >= Program.DispSize.Y || this.Location.X < 0 || this.Location.Y < 0) {
                this.Location = new Point(300, 300);
            }
            if(bool.Parse(setting.GetValue("General", "TopMost", "False"))) {
                this.TopMost = true;
                checkBox1.Checked = true;
            }
            SaveDir = setting.GetValue("General", "SaveDir", "");
            comboBox1.SelectedIndex = 2;
            radioButton1.Select();
        }

        private int GetScreenId() {
            // 指定したグループ内のラジオボタンでチェックされている物を取り出す
            var RadioButtonChecked_InGroup = this.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked == true);
            return int.Parse(RadioButtonChecked_InGroup.Text) - 1;
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                window = new WindowController.Window(textBox1.Text);
                this.Text = textBox1.Text;
                comboBox1.SelectedIndex = 0;
            }
            catch (System.Exception ex){
                this.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Bitmap capture;
            if (comboBox1.SelectedIndex == 0) capture = window.CaptureWindowDC();
            else if (comboBox1.SelectedIndex == 1) capture = window.CaptureWindow();
            else capture = WindowController.Mouse.CaptureScreen(start, end);
            screen[GetScreenId()] = capture;
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = capture;
        }

        private void button3_Click(object sender, EventArgs e) {
            var token = CoreTweet.Tokens.Create(setting.GetValue("Twitter", "APIKey", "")
                , setting.GetValue("Twitter", "APISecret", "")
                , setting.GetValue("Twitter", "AccessToken", "")
                , setting.GetValue("Twitter", "AccessTokenSecret", ""));
            List<long> MediaId = new List<long>();
            if (checkBox2.Checked && screen[0] != null) MediaId.Add(token.Media.Upload(media: ConvertImageToBytes(screen[0])).MediaId);
            if (checkBox3.Checked && screen[1] != null) MediaId.Add(token.Media.Upload(media: ConvertImageToBytes(screen[1])).MediaId);
            if (checkBox4.Checked && screen[2] != null) MediaId.Add(token.Media.Upload(media: ConvertImageToBytes(screen[2])).MediaId);
            if (checkBox5.Checked && screen[3] != null) MediaId.Add(token.Media.Upload(media: ConvertImageToBytes(screen[3])).MediaId);
            string statustext = textBox2.Text;
            if (checkBox6.Checked) statustext += " " + textBox3.Text;
            Status s = token.Statuses.Update(
                            status: statustext,
                            media_ids: MediaId
                        );
            textBox2.Text = "";
            button3.Text = "140";
        }

        public static byte[] ConvertImageToBytes(System.Drawing.Image img) {
            // 入力引数の異常時のエラー処理
            if (img == null) return null;
            byte[] ImageBytes;

            // メモリストリームの生成
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream()) {
                // Image画像を、Imageのファイル形式でストリームに保存
                img.Save(ms, ImageFormat.Png);
                // ストリームのデータをバイト型配列に変換
                ImageBytes = ms.ToArray();
                // ストリームのクローズ
                ms.Close();
            }
            return ImageBytes;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            this.TopMost = checkBox1.Checked;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            if (checkBox6.Checked) button3.Text = (140 - textBox2.Text.Length - textBox3.Text.Length).ToString();
            else button3.Text = (140 - textBox2.Text.Length).ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            if (pictureBox1.Image == null) return;
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = textBox1.Text + "_" + System.DateTime.Now.ToString()
                                                                    .Replace('/','-')
                                                                    .Replace(' ', '_')
                                                                    .Replace(':','-');
            sfd.InitialDirectory = SaveDir;
            //[ファイルの種類]に表示される選択肢を指定する
            sfd.Filter = "PNGファイル(*.png)|*.png";
            //タイトルを設定する
            sfd.Title = "スクショ保存";
            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image.Save(sfd.FileName, ImageFormat.Png);
                SaveDir = System.IO.Path.GetDirectoryName(sfd.FileName);
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string fileName = files[0];
            if (System.IO.Path.GetExtension(fileName) == ".lnk") fileName = ShortcutToFilePath(fileName);
            else if (System.IO.Path.GetExtension(fileName) != ".exe") return;
            textBox1.Text = System.IO.Path.GetFileNameWithoutExtension(fileName);
            string workDir = System.IO.Directory.GetCurrentDirectory();
            System.IO.Directory.SetCurrentDirectory(System.IO.Path.GetDirectoryName(fileName));
            System.Diagnostics.Process.Start(fileName);
            System.IO.Directory.SetCurrentDirectory(workDir);
        }
        
        private string ShortcutToFilePath(string path) {
            // オブジェクトの生成、注意：WshShellClassでない
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

            // ショートカットオブジェクトの生成、注意：キャストが必要
            IWshRuntimeLibrary.IWshShortcut shortcut
                                = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(path);

            // リンク先ファイル
            return shortcut.TargetPath.ToString();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.All;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            this.Capture = true;
            selmode = true;
            Cursor.Current = Cursors.Cross;
            WindowController.Mouse.SetMouseLButtonDown();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            if (selmode) {
                if (!is_end) {
                    start.X = Cursor.Position.X;
                    start.Y = Cursor.Position.Y;
                    is_end = true;
                    this.Capture = false;
                    WindowController.Mouse.SetMouseLButtonUp();
                    label1.Text = "X:" + start.X + " Y:" + start.Y;
                } else {
                    end.X = Cursor.Position.X;
                    end.Y = Cursor.Position.Y;
                    is_end = false;
                    this.Capture = false;
                    WindowController.Mouse.SetMouseLButtonUp();
                    label1.Text += " W:" + (end.X - start.X) + " H:" + (end.Y - start.Y);
                }
            }
            selmode = false;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            pictureBox1.Image = screen[GetScreenId()];
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            setting.SetValue("General", "PosX", this.Location.X.ToString());
            setting.SetValue("General", "PosY", this.Location.Y.ToString());
            setting.SetValue("General", "TopMost", this.TopMost.ToString());
            setting.SetValue("General", "SaveDir", SaveDir);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e) {
            keydowncalled = false;
            if (e.KeyData == (Keys.Control | Keys.Enter)) {
                keydowncalled = true;
                button3_Click(null, null);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (keydowncalled) e.Handled = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e) {
            if (checkBox7.Checked) window.SetWindowDispMode(2);
            else window.SetWindowDispMode(3);
        }

        private void button7_Click(object sender, EventArgs e) {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            if (screen[GetScreenId()] != null) screen[GetScreenId()].Dispose();
            screen[GetScreenId()] = null;
        }
    }
}
