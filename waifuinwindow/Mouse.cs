using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WindowController {
    public class Mouse {
        internal class NativeMethods {
            [DllImport("user32.dll")]
            extern public static void
              mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
            [DllImport("user32.dll")]
            extern public static int GetMessageExtraInfo();

            public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
            public const int MOUSEEVENTF_LEFTUP = 0x0004;
        }

        public static void SetMouseLButtonDown() {
            NativeMethods.mouse_event(
              NativeMethods.MOUSEEVENTF_LEFTDOWN,
              0, 0, 0, NativeMethods.GetMessageExtraInfo());
        }

        public static void SetMouseLButtonUp() {
            NativeMethods.mouse_event(
              NativeMethods.MOUSEEVENTF_LEFTUP,
              0, 0, 0, NativeMethods.GetMessageExtraInfo());
        }

        /// <summary>
		/// 選択した領域を画像としてキャプチャする
		/// </summary>
        public static Bitmap CaptureScreen(Point Start, Point End) {
            //Bitmapの作成
            Bitmap bitmap;
            try {
                bitmap = new Bitmap(End.X - Start.X, End.Y - Start.Y);
            }
            catch {
                return null;
            }
            Graphics graphics = Graphics.FromImage(bitmap);
            using (graphics) {
                graphics.CopyFromScreen(Start, new Point(0, 0), bitmap.Size);
            }
            return bitmap;
        }
    }
}
