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
        public IniFile Setting = new IniFile("./setting.ini");
        WindowController.Window Target;
        bool keydowncalled = false;
        Bitmap[] screen = new Bitmap[4];
        Dictionary<string, string> WindowList = new Dictionary<string, string>();

        public Form1() {
            InitializeComponent();
            this.Location = new Point(int.Parse(Setting.GetValue("General", "PosX", "300")), int.Parse(Setting.GetValue("General", "PosY", "300")));
            if (this.Location.X - 100 >= Program.DispSize.Width || this.Location.Y - 100 >= Program.DispSize.Height) {
                this.Location = new Point(300, 300);
            }
            if(bool.Parse(Setting.GetValue("General", "TopMost", "False"))) {
                this.TopMost = true;
                TopMost_Me.Checked = true;
            }
            if(bool.Parse(Setting.GetValue("Twitter", "Auth", "False")) == false) {
                TweetButton.Text = "認証";
                TweetStatus.Text = "認証を行ってください";           
            }
            ModeSelect.SelectedIndex = 2;
            Screen1.Select();
            UpdateButton_Click(null, null);
        }

        private int GetScreenId() {
            // 指定したグループ内のラジオボタンでチェックされている物を取り出す
            var RadioButtonChecked_InGroup = this.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked == true);
            return int.Parse(RadioButtonChecked_InGroup.Text) - 1;
        }

        private void exeSetButton_Click(object sender, EventArgs e) {
            if (exeName.Text == "") return;
            try {
                exeName.Text = WindowList[exeName.Text];
            }
            catch { }
            try {
                Target = new WindowController.Window(exeName.Text);
                StatusLabel1.Text = exeName.Text;
                ModeSelect.SelectedIndex = 0;
                TopMost_Target.Checked = false;
            }
            catch (System.Exception ex){
                StatusLabel1.Text = ex.Message;
            }
        }

        private void ImageCapButton_Click(object sender, EventArgs e) {
            Bitmap capture;
            this.Opacity = 0;
            try {
                if (ModeSelect.SelectedIndex == 0) capture = Target.CaptureWindowDC();
                else if (ModeSelect.SelectedIndex == 1) capture = Target.CaptureWindow();
                else capture = WindowController.Mouse.CaptureScreen(Program.SelArea);
            }
            catch {
                this.Opacity = 1;
                return;
            }
            this.Opacity = 1;
            screen[GetScreenId()] = capture;
            if (capturedImage.Image != null) capturedImage.Image.Dispose();
            capturedImage.Image = capture;
        }

        private void TweetButton_Click(object sender, EventArgs e) {
            // 認証
            if(!Convert.ToBoolean(Setting.GetValue("Twitter", "Auth", "False"))) {
                if (MessageBox.Show("Twitter認証がされていません。\n認証を行いますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                    Form3 OAuth = new Form3();
                    OAuth.ShowDialog(this);
                    Setting.SetValue("Twitter", "Auth", "True");
                    TweetText_TextChanged(null, null);
                    TweetStatus.Text = "認証済み";
                }
                return;
            }
            // 固まるからどうにかしなければ
            if(Convert.ToInt16(TweetButton.Text) < 0) {
                TweetStatus.Text = "140文字を超えています";
                return;
            }
            Tokens token = null;
            try {
                token = CoreTweet.Tokens.Create(DecodeKey.GetKey(1)
                    , DecodeKey.GetKey(2)
                    , Setting.GetValue("Twitter", "AccessToken", "")
                    , Setting.GetValue("Twitter", "AccessTokenSecret", ""));
            }
            catch (System.Exception ex)  {
                TweetStatus.Text = "トークンエラー";
                MessageBox.Show("トークンの生成に失敗しました\nこのエラーが複数回出る場合はsetting.iniを一度削除してください\n" + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var MediaId = new List<long>();
            TweetStatus.Text = "ツイートを送信中";
            this.Refresh();
            if (Image1.Checked && screen[0] != null) MediaId.Add(token.Media.Upload(media: ConvertImageToBytes(screen[0])).MediaId);
            if (Image2.Checked && screen[1] != null) MediaId.Add(token.Media.Upload(media: ConvertImageToBytes(screen[1])).MediaId);
            if (Image3.Checked && screen[2] != null) MediaId.Add(token.Media.Upload(media: ConvertImageToBytes(screen[2])).MediaId);
            if (Image4.Checked && screen[3] != null) MediaId.Add(token.Media.Upload(media: ConvertImageToBytes(screen[3])).MediaId);
            string statustext = TweetText.Text;
            if (FooterMode.Checked) statustext += " " + FooterText.Text;
            if (statustext == "" && MediaId.Count == 0) {
                TweetStatus.Text = "送信内容がありません";
                return;
            }
            try {
                Status s = token.Statuses.Update(
                                status: statustext,
                                media_ids: MediaId
                            );
            }
            catch (System.Exception ex) {
                TweetStatus.Text = "送信エラー";
                MessageBox.Show("ツイートの送信に失敗しました\n画像サイズが大きすぎる可能性があります\n" + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TweetText.Text = "";
            TweetButton.Text = "140";
            TweetStatus.Text = "送信完了";
        }

        private byte[] ConvertImageToBytes(Image img) {
            // 入力引数の異常時のエラー処理
            if (img == null) return null;
            byte[] ImageBytes;
            // リサイズ処理
            if (Resize50.Checked) {
                Bitmap canvas = new Bitmap(img.Width/2, img.Height/2);
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);
                //Bitmapオブジェクトの作成
                Bitmap image = new Bitmap(img);
                //補間方法として双三次補間を指定する
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                //画像を縮小して描画する
                g.DrawImage(image, 0, 0, img.Width/2, img.Height/2);
                //BitmapとGraphicsオブジェクトを破棄
                image.Dispose();
                g.Dispose();
                img = canvas;
            }
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

        private void TopMost_Me_CheckedChanged(object sender, EventArgs e) {
            this.TopMost = TopMost_Me.Checked;
        }

        private void TweetText_TextChanged(object sender, EventArgs e) {
            if (FooterMode.Checked) TweetButton.Text = (140 - TweetText.Text.Length - FooterText.Text.Length).ToString();
            else TweetButton.Text = (140 - TweetText.Text.Length).ToString();
        }

        private void ImageSaveButton_Click(object sender, EventArgs e) {
            if (capturedImage.Image == null) return;
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = exeName.Text + "_" + System.DateTime.Now.ToString()
                                                                    .Replace('/','-')
                                                                    .Replace(' ', '_')
                                                                    .Replace(':','-');
            sfd.InitialDirectory = Setting.GetValue("General", "SaveDir");
            //[ファイルの種類]に表示される選択肢を指定する
            sfd.Filter = "PNGファイル(*.png)|*.png";
            //タイトルを設定する
            sfd.Title = "スクショ保存";
            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK) {
                capturedImage.Image.Save(sfd.FileName, ImageFormat.Png);
                Setting.SetValue("General", "SaveDir", System.IO.Path.GetDirectoryName(sfd.FileName));
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string fileName = files[0];
            if (System.IO.Path.GetExtension(fileName) == ".lnk") fileName = ShortcutToFilePath(fileName);
            else if (System.IO.Path.GetExtension(fileName) != ".exe") return;
            exeName.Text = System.IO.Path.GetFileNameWithoutExtension(fileName);
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

        private void AreaSelButton_Click(object sender, EventArgs e) {
            var BeforeSel = Program.SelArea;
            Form2 AreaSel = new Form2();
            this.Visible = false;
            AreaSel.ShowDialog(this);
            AreaSel.Dispose();
            if (BeforeSel != Program.SelArea) {
                this.AreaLabel.Text = "X:" + Program.SelArea.X.ToString();
                this.AreaLabel.Text += " Y:" + Program.SelArea.Y.ToString();
                this.AreaLabel.Text += " W:" + Program.SelArea.Width.ToString();
                this.AreaLabel.Text += " H:" + Program.SelArea.Height.ToString();
                Bitmap capture;
                try {
                    capture = WindowController.Mouse.CaptureScreen(Program.SelArea);
                    screen[GetScreenId()] = capture;
                    if (capturedImage.Image != null) capturedImage.Image.Dispose();
                    capturedImage.Image = capture;
                }
                catch {
                }
            }
            this.Visible = true;
        }

        private void Screen_CheckedChanged(object sender, EventArgs e) {
            capturedImage.Image = screen[GetScreenId()];
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Setting.SetValue("General", "PosX", this.Location.X.ToString());
            Setting.SetValue("General", "PosY", this.Location.Y.ToString());
            Setting.SetValue("General", "TopMost", this.TopMost.ToString());
            if (TopMost_Target.Checked) Target.SetWindowDispMode(3);
        }

        private void TweetText_KeyDown(object sender, KeyEventArgs e) {
            keydowncalled = false;
            if (e.KeyData == (Keys.Control | Keys.Enter)) {
                keydowncalled = true;
                TweetButton_Click(null, null);
            }
        }

        private void TweetText_KeyPress(object sender, KeyPressEventArgs e) {
            if (keydowncalled) e.Handled = true;
        }

        private void TopMost_Target_CheckedChanged(object sender, EventArgs e) {
            if (TopMost_Target.Checked) Target.SetWindowDispMode(2);
            else Target.SetWindowDispMode(3);
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            if (capturedImage.Image != null) capturedImage.Image.Dispose();
            capturedImage.Image = null;
            if (screen[GetScreenId()] != null) screen[GetScreenId()].Dispose();
            screen[GetScreenId()] = null;
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            WindowList.Clear();
            exeName.Items.Clear();
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses()) {
                //プロセスを探す
                if (!IntPtr.Zero.Equals(p.MainWindowHandle) && p.MainWindowTitle != "") {
                    try {
                        WindowList.Add(p.MainWindowTitle, p.ProcessName);
                        exeName.Items.Add(p.MainWindowTitle);
                    }
                    catch { }
                }
            }
        }
    }
}
