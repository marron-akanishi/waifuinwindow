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
        IniFile twitter = new IniFile("./twitter.ini");
        Point start, end;
        bool is_end = false;
        bool selmode = false;

        public Form1() {
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
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
            Bitmap screen;
            if (comboBox1.SelectedItem.ToString() == "DC") screen = window.CaptureWindowDC();
            else if (comboBox1.SelectedItem.ToString() == "noDC") screen = window.CaptureWindow();
            else screen = WindowController.Mouse.CaptureScreen(start, end);
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = screen;
        }

        private void button3_Click(object sender, EventArgs e) {
            if (pictureBox1.Image == null) return;
            var token = CoreTweet.Tokens.Create(twitter.GetValue("Twitter", "APIKey", "")
                , twitter.GetValue("Twitter", "APISecret", "")
                , twitter.GetValue("Twitter", "AccessToken", "")
                , twitter.GetValue("Twitter", "AccessTokenSecret", ""));

            MediaUploadResult first = token.Media.Upload(media: ConvertImageToBytes(pictureBox1.Image));
            string statustext = textBox2.Text;
            Status s = token.Statuses.Update(
                            status: statustext,
                            media_ids: new long[] {first.MediaId}
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
            button3.Text = (140 - textBox2.Text.Length).ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            if (pictureBox1.Image == null) return;
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = textBox1.Text + "_" + System.DateTime.Now.ToString()
                                                                    .Replace('/','-')
                                                                    .Replace(' ', '_')
                                                                    .Replace(':','-');
            //[ファイルの種類]に表示される選択肢を指定する
            sfd.Filter = "PNGファイル(*.png)|*.png";
            //タイトルを設定する
            sfd.Title = "スクショ保存";
            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK) pictureBox1.Image.Save(sfd.FileName, ImageFormat.Png);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string fileName = files[0];
            if (System.IO.Path.GetExtension(fileName) != ".exe") return;
            textBox1.Text = System.IO.Path.GetFileNameWithoutExtension(fileName);
            string workDir = System.IO.Directory.GetCurrentDirectory();
            System.IO.Directory.SetCurrentDirectory(System.IO.Path.GetDirectoryName(fileName));
            System.Diagnostics.Process.Start(fileName);
            System.IO.Directory.SetCurrentDirectory(workDir);
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
                } else {
                    end.X = Cursor.Position.X;
                    end.Y = Cursor.Position.Y;
                    is_end = false;
                    this.Capture = false;
                    WindowController.Mouse.SetMouseLButtonUp();
                    label1.Text = "X:" + start.X + " Y:" + start.Y + " W:" + (end.X - start.X) + " H:" + (end.Y - start.Y);
                }
            }
            selmode = false;
        }

        private void button6_Click(object sender, EventArgs e) {
            if (!timer1.Enabled) {
                timer1.Tick += new EventHandler(this.button2_Click);
                timer1.Interval = Convert.ToInt16(numericUpDown1.Value) * 100;
                timer1.Enabled = true;
                button6.Text = "stop";
            } else {
                timer1.Enabled = false;
                button6.Text = "start";
            }
        }
    }
}
