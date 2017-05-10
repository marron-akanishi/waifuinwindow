using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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

        const int LOGPIXELSX = 88;
        [DllImport("user32.dll")]
        extern static bool SetProcessDPIAware();
        [DllImport("user32.dll")]
        extern static IntPtr GetWindowDC(IntPtr hwnd);
        [DllImport("gdi32.dll")]
        extern static int GetDeviceCaps(IntPtr hdc, int index);
        [DllImport("user32.dll")]
        extern static int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //全ディスプレイを合わせたサイズを取得する
            SetProcessDPIAware();
            var dc = GetWindowDC(IntPtr.Zero);
            double dpi = GetDeviceCaps(dc, LOGPIXELSX);
            ReleaseDC(IntPtr.Zero, dc);
            DispSize.X = (int)System.Windows.SystemParameters.VirtualScreenLeft;
            DispSize.Y = (int)System.Windows.SystemParameters.VirtualScreenTop;
            DispSize.Width = (int)(System.Windows.SystemParameters.VirtualScreenWidth * dpi/96);
            DispSize.Height = (int)(System.Windows.SystemParameters.VirtualScreenHeight * dpi / 96);
            Application.Run(new Form1());
        }
    }

    /// <summary>
    /// グローバルホットキーを登録するクラス。
    /// 使用後は必ずDisposeすること。
    /// </summary>
    public class HotKey : IDisposable {
        HotKeyForm form;
        /// <summary>
        /// ホットキーが押されると発生する。
        /// </summary>
        public event EventHandler HotKeyPush;

        /// <summary>
        /// ホットキーを指定して初期化する。
        /// 使用後は必ずDisposeすること。
        /// </summary>
        /// <param name="modKey">修飾キー</param>
        /// <param name="key">キー</param>
        public HotKey(MOD_KEY modKey, Keys key) {
            form = new HotKeyForm(modKey, key, raiseHotKeyPush);
        }

        private void raiseHotKeyPush() {
            if (HotKeyPush != null) {
                HotKeyPush(this, EventArgs.Empty);
            }
        }

        public void Dispose() {
            form.Dispose();
        }

        private class HotKeyForm : Form {
            [DllImport("user32.dll")]
            extern static int RegisterHotKey(IntPtr HWnd, int ID, MOD_KEY MOD_KEY, Keys KEY);

            [DllImport("user32.dll")]
            extern static int UnregisterHotKey(IntPtr HWnd, int ID);

            const int WM_HOTKEY = 0x0312;
            int id;
            ThreadStart proc;

            public HotKeyForm(MOD_KEY modKey, Keys key, ThreadStart proc) {
                this.proc = proc;
                for (int i = 0x0000; i <= 0xbfff; i++) {
                    if (RegisterHotKey(this.Handle, i, modKey, key) != 0) {
                        id = i;
                        break;
                    }
                }
            }

            protected override void WndProc(ref Message m) {
                base.WndProc(ref m);

                if (m.Msg == WM_HOTKEY) {
                    if ((int)m.WParam == id) {
                        proc();
                    }
                }
            }

            protected override void Dispose(bool disposing) {
                UnregisterHotKey(this.Handle, id);
                base.Dispose(disposing);
            }
        }
    }

    /// <summary>
    /// HotKeyクラスの初期化時に指定する修飾キー
    /// </summary>
    public enum MOD_KEY : int {
        ALT = 0x0001,
        CONTROL = 0x0002,
        SHIFT = 0x0004,
    }
}
