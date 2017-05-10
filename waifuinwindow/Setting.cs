using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace waifuinwindow {
    public class Setting {
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

        string filePath = "./setting.ini";

        #region General
        public int PosX {
            get { return Convert.ToInt32(GetValue("General", "PosX", "300")); }
            set { SetValue("General", "PosX", value.ToString()); }
        }

        public int PosY {
            get { return Convert.ToInt32(GetValue("General", "PosY", "300")); }
            set { SetValue("General", "PosY", value.ToString()); }
        }

        public bool TopMost {
            get { return Convert.ToBoolean(GetValue("General", "TopMost", "False")); }
            set { SetValue("General", "TopMost", value.ToString()); }
        }

        public string SaveDir {
            get { return GetValue("General", "SaveDir"); }
            set { SetValue("General", "SaveDir", value); }
        }

        public bool UseSound {
            get { return Convert.ToBoolean(GetValue("General", "UseSound", "False")); }
            set { SetValue("General", "UseSound", value.ToString()); }
        }
        #endregion

        #region Twitter
        public bool Auth {
            get { return Convert.ToBoolean(GetValue("Twitter", "Auth", "False")); }
            set { SetValue("Twitter", "Auth", value.ToString()); }
        }

        public string Token {
            get { return GetValue("Twitter", "AccessToken"); }
            set { SetValue("Twitter", "AccessToken", value); }
        }

        public string TokenSecret {
            get { return GetValue("Twitter", "AccessTokenSecret"); }
            set { SetValue("Twitter", "AccessTokenSecret", value); }
        }
        #endregion

        #region Shortcut
        public bool UseShortcut {
            get { return Convert.ToBoolean(GetValue("Shortcut", "Enable", "False")); }
            set { SetValue("Shortcut", "Enable", value.ToString()); }
        }
        public bool UseAlt {
            get { return Convert.ToBoolean(GetValue("Shortcut", "UseAlt", "False")); }
            set { SetValue("Shortcut", "UseAlt", value.ToString()); }
        }
        public bool UseCtrl {
            get { return Convert.ToBoolean(GetValue("Shortcut", "UseCtrl", "False")); }
            set { SetValue("Shortcut", "UseCtrl", value.ToString()); }
        }
        public bool UseShift {
            get { return Convert.ToBoolean(GetValue("Shortcut", "UseShift", "False")); }
            set { SetValue("Shortcut", "UseShift", value.ToString()); }
        }
        public string ShortcutKey {
            get { return GetValue("Shortcut", "Key"); }
            set { SetValue("Shortcut", "Key", value); }
        }
        #endregion

        #region IniMethods
        /// <summary>
        /// sectionとkeyからiniファイルの設定値を取得します。
        /// 指定したsectionとkeyの組合せが無い場合はdefaultvalueで指定した値が返ります。
        /// </summary>
        /// <returns>
        /// 指定したsectionとkeyの組合せが無い場合はdefaultvalueで指定した値が返ります。
        /// </returns>
        private string GetValue(string section, string key, string defaultvalue = "") {
            StringBuilder sb = new StringBuilder(256);
            GetPrivateProfileString(section, key, defaultvalue, sb, sb.Capacity, filePath);
            return sb.ToString();
        }

        /// <summary>
        /// 指定されたsectionとkeyにデータを書き込みます。
        /// 指定したsectionとkeyの組合せが無い場合は生成されます。
        /// </summary>
        private void SetValue(string section, string key, string value) {
            WritePrivateProfileString(section, key, value, filePath);
            return;
        }
        #endregion
    }
}
