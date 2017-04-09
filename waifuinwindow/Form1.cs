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
    }
}
