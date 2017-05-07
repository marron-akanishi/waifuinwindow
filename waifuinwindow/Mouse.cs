using System.Drawing;

namespace WindowController {
    public class Mouse {
        /// <summary>
		/// 選択した領域を画像としてキャプチャする
		/// </summary>
        public static Bitmap CaptureScreen(Rectangle Area) {
            //Bitmapの作成
            Bitmap bitmap;
            try {
                bitmap = new Bitmap(Area.Width, Area.Height);
            }
            catch {
                return null;
            }
            Graphics graphics = Graphics.FromImage(bitmap);
            using (graphics) {
                graphics.CopyFromScreen(new Point(Area.X,Area.Y), new Point(0, 0), bitmap.Size);
            }
            return bitmap;
        }
    }
}
