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

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                window = new WindowController.Window(textBox1.Text);
                this.Text = textBox1.Text;
                button2.Enabled = true;
            }
            catch (System.Exception ex){
                this.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Bitmap screen;
            if (checkBox2.Checked) screen = window.CaptureImage();
            else screen = window.CaptureScreen();
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

            //[ファイルの種類]に表示される選択肢を指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            sfd.Filter = "PNGファイル(*.png)|*.png";
            //タイトルを設定する
            sfd.Title = "スクショ保存";
            
            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image.Save(sfd.FileName, ImageFormat.Png);
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string fileName = files[0];
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
    }
}
