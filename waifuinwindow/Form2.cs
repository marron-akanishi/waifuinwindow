using System;
using System.Drawing;
using System.Windows.Forms;

namespace waifuinwindow {
    public partial class Form2 : Form {
        Bitmap SelAreaRect;
        Point Start = new Point(0, 0);
        Point End = new Point(0, 0);
        bool get = false;

        public Form2() {
            InitializeComponent();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                get = true;
                Start = e.Location;
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e) {
            if (get && e.Button == MouseButtons.Left) {
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(SelAreaRect);
                //Penオブジェクトの作成
                Pen p = new Pen(Color.Red, 2);
                g.Clear(SystemColors.Control);
                g.DrawRectangle(p, Start.X, Start.Y, Math.Abs(e.X - Start.X), Math.Abs(e.Y - Start.Y));
                //リソースを解放する
                p.Dispose();
                g.Dispose();
                pictureBox1.Image = SelAreaRect;
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e) {
            if (get && e.Button == MouseButtons.Left) {
                End = e.Location;
                Program.SelArea.X = Start.X + this.Location.X;
                Program.SelArea.Y = Start.Y + this.Location.Y;
                Program.SelArea.Width = Math.Abs(End.X - Start.X);
                Program.SelArea.Height = Math.Abs(End.Y - Start.Y);
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e) {
            this.Location = new Point(Program.DispSize.X, Program.DispSize.Y);
            this.Size = new Size(Program.DispSize.Width, Program.DispSize.Height);
            SelAreaRect = new Bitmap(this.Size.Width, this.Size.Height);
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
