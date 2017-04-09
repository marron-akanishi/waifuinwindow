﻿using System;
using System.Diagnostics;
using System.Drawing;

namespace WindowController
{
	/// <summary>
	/// 操作対象のウィンドウを表すクラス
	/// </summary>
	public class Window
	{
		/// <summary>
		/// 対象のウィンドウのハンドル
		/// </summary>
		protected IntPtr handle;

        private const int SRCCOPY = 13369376;
        private const int CAPTUREBLT = 1073741824;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="processName">対象とするウィンドウを持つプロセスの名前</param>
        public Window(string processName)
		{
			foreach (Process process in Process.GetProcessesByName(processName))
			{
				IntPtr handle = process.MainWindowHandle;
				if (handle == IntPtr.Zero)
					continue;
				this.handle = handle;
			}
			if (this.handle == IntPtr.Zero)
			{
				throw new Exception(
					string.Format("{0}のウィンドウが見つかりません。", processName)
				);
			}
		}

		/// <summary>
		/// ウィドウが最小化されている場合、元に戻す
		/// </summary>
		public void Restore()
		{
			if (NativeCall.IsIconic(this.handle))
				NativeCall.ShowWindow(this.handle, NativeCall.WindowShowStyle.Restore);
		}

        /// <summary>
		/// クライアント領域を画像としてキャプチャする
		/// </summary>
		/// <param name="rectangle">クライアント領域内のキャプチャしたい領域。指定しない場合はクライアント領域全体をキャプチャする。</param>
		/// <returns>キャプチャした画像データ</returns>
		public Bitmap CaptureImage(Rectangle rectangle = default(Rectangle)) {
            // ウィンドウが最小化されていた場合、もとに戻す
            // （ウィンドウが最小化されていると座標を取得できないから）
            this.Restore();
            // ウィンドウを最前面に表示する（アクティブにはしない）
            this.BringWindowToTop();

            // クライアント領域の左上のスクリーン座標を取得
            NativeCall.POINT screenPoint = new NativeCall.POINT(0, 0);
            NativeCall.ClientToScreen(this.handle, out screenPoint);

            // キャプチャ領域を取得
            NativeCall.RECT clientRect = new NativeCall.RECT();
            NativeCall.GetClientRect(this.handle, out clientRect);
            if (rectangle == default(Rectangle)) {
                rectangle = new Rectangle(
                    clientRect.left,
                    clientRect.top,
                    clientRect.right - clientRect.left,
                    clientRect.bottom - clientRect.top
                );
            }
            Point captureStartPoint = new Point(
                screenPoint.X + rectangle.X,
                screenPoint.Y + rectangle.Y
            );
            //Bitmapの作成
            Bitmap bitmap;
            try {
                bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            }
            catch {
                return null;
            }
            Graphics graphics = Graphics.FromImage(bitmap);
            using (graphics) {
                graphics.CopyFromScreen(captureStartPoint, new Point(0, 0), rectangle.Size);
            }
            return bitmap;
        }

        /// <summary>
		/// ウィンドウのクライアント領域を画像としてキャプチャする
		/// </summary>
        public Bitmap CaptureScreen() {
            // ウィンドウを最前面に表示する（アクティブにはしない）
            this.BringWindowToTop();
            //アクティブなウィンドウのデバイスコンテキストを取得
            IntPtr winDC = NativeCall.GetWindowDC(handle);
            //ウィンドウの大きさを取得
            NativeCall.RECT winRect = new NativeCall.RECT();
            NativeCall.GetWindowRect(handle,out winRect);
            // クライアント領域の左上のスクリーン座標を取得
            NativeCall.POINT screenPoint = new NativeCall.POINT(0, 0);
            NativeCall.ClientToScreen(this.handle, out screenPoint);
            // クライアント領域を取得
            NativeCall.RECT clientRect = new NativeCall.RECT();
            NativeCall.GetClientRect(this.handle, out clientRect);
            //Bitmapの作成
            Bitmap bmp;
            try {
                bmp = new Bitmap(clientRect.right, clientRect.bottom);
            }
            catch {
                return null;
            }
            //Graphicsの作成
            Graphics g = Graphics.FromImage(bmp);
            //Graphicsのデバイスコンテキストを取得
            IntPtr hDC = g.GetHdc();
            //Bitmapに画像をコピーする
            NativeCall.BitBlt(hDC, 0, 0, bmp.Width, bmp.Height,
                winDC, screenPoint.X - winRect.left, screenPoint.Y - winRect.top, SRCCOPY);
            //解放
            g.ReleaseHdc(hDC);
            g.Dispose();
            NativeCall.ReleaseDC(handle, winDC);

            return bmp;
        }

        /// <summary>
        /// 指定したウィンドウを最前面に表示する
        /// </summary>
        /// <param name="windowHandle"></param>
        public void BringWindowToTop()
        {
            NativeCall.SetWindowPos(this.handle, (IntPtr)NativeCall.SpecialWindowHandles.HWND_TOP, 0, 0, 0, 0,
                NativeCall.SetWindowPosFlags.SWP_NOACTIVATE |
                NativeCall.SetWindowPosFlags.SWP_NOMOVE |
                NativeCall.SetWindowPosFlags.SWP_NOSIZE |
                NativeCall.SetWindowPosFlags.SWP_NOSENDCHANGING |
                NativeCall.SetWindowPosFlags.SWP_SHOWWINDOW
            );
        }
	}
}
