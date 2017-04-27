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

namespace waifuinwindow {
    public partial class Form3 : Form {
        OAuth.OAuthSession session;

        public Form3() {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {
            session = OAuth.Authorize(DecodeKey.GetKey(1), DecodeKey.GetKey(2));
            System.Diagnostics.Process.Start(session.AuthorizeUri.AbsoluteUri);
        }

        private void button1_Click(object sender, EventArgs e) {
            string pin = textBox1.Text;
            Tokens tokens = null;

            try {
                tokens = session.GetTokens(pin);
            }
            catch {
                if(MessageBox.Show("認証に失敗しました\n認証画面をもう一度表示しますか？", "エラー", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                    Form3_Load(null, null);
                } else {
                    return;
                }
            }
            ((Form1)this.Owner).setting.SetValue("Twitter", "AccessToken", tokens.AccessToken);
            ((Form1)this.Owner).setting.SetValue("Twitter", "AccessTokenSecret", tokens.AccessTokenSecret);
            ((Form1)this.Owner).setting.SetValue("Twitter", "Auth", "True");
            this.Close();
        }
    }

    static public class DecodeKey {
        static String ConsumerKey = "cE91emRSS0VMbVdXMkRMaUxFZTJzTE9MRg@@";
        static String ConsumerSecret = "N1hXMWpXbTg1ZW94cnV5VmljczF4bEpUNmV2ZzlJYXBTMkE4Y1J5dDhqZnhjZGlvejU@";

        static public string GetKey(int keyno) {
            string key = "";
            Encoding enc = Encoding.GetEncoding("UTF-8");

            // Key:1->CK 2->CS
            switch (keyno) {
                case 1:
                    key = ConsumerKey.Replace('@', '=');
                    key = enc.GetString(Convert.FromBase64String(key));
                    break;
                case 2:
                    key = ConsumerSecret.Replace('@', '=');
                    key = enc.GetString(Convert.FromBase64String(key));
                    break;
            }

            return key;
        }
    }
}
