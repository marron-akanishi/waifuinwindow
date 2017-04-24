using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waifuinwindow {
    static class Program {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        /// 
        static public Rectangle DispSize = new Rectangle(0, 0, 0, 0);
        static public Rectangle SelArea = new Rectangle(0, 0, 0, 0);

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //全ディスプレイを合わせたサイズを取得する
            DispSize.X = (int)System.Windows.SystemParameters.VirtualScreenLeft;
            DispSize.Y = (int)System.Windows.SystemParameters.VirtualScreenTop;
            DispSize.Width = (int)System.Windows.SystemParameters.VirtualScreenWidth;
            DispSize.Height = (int)System.Windows.SystemParameters.VirtualScreenHeight;
            Application.Run(new Form1());
        }
    }

    public class IniFile {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedstring,
            int nSize,
            string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpstring,
            string lpFileName);

        string filePath;

        /// <summary>
        /// ファイル名を指定して初期化します。
        /// ファイルが存在しない場合は初回書き込み時に作成されます。
        /// </summary>
        public IniFile(string filePath) {
            this.filePath = filePath;
        }

        /// <summary>
        /// sectionとkeyからiniファイルの設定値を取得、設定します。 
        /// </summary>
        /// <returns>指定したsectionとkeyの組合せが無い場合は""が返ります。</returns>
        public string this[string section, string key] {
            set {
                WritePrivateProfileString(section, key, value, filePath);
            }
            get {
                StringBuilder sb = new StringBuilder(256);
                GetPrivateProfileString(section, key, string.Empty, sb, sb.Capacity, filePath);
                return sb.ToString();
            }
        }

        /// <summary>
        /// sectionとkeyからiniファイルの設定値を取得します。
        /// 指定したsectionとkeyの組合せが無い場合はdefaultvalueで指定した値が返ります。
        /// </summary>
        /// <returns>
        /// 指定したsectionとkeyの組合せが無い場合はdefaultvalueで指定した値が返ります。
        /// </returns>
        public string GetValue(string section, string key, string defaultvalue = "") {
            StringBuilder sb = new StringBuilder(256);
            GetPrivateProfileString(section, key, defaultvalue, sb, sb.Capacity, filePath);
            return sb.ToString();
        }

        /// <summary>
        /// 指定されたsectionとkeyにデータを書き込みます。
        /// 指定したsectionとkeyの組合せが無い場合は生成されます。
        /// </summary>
        public void SetValue(string section, string key, string value) {
            WritePrivateProfileString(section, key, value, filePath);
            return;
        }
    }
}
