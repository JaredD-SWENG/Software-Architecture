using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_SWENG421
{
    public partial class Form1 : Form
    {
        private int red;
        private int green;
        private int blue;
        private int startX;
        private int startY;
        private int endX;
        private int endY;
        private Shape shape = new LineShape();
        private bool down = false;
        private Bitmap bg, fg;
        private Graphics bgg, fgg;
        private int oldPanelWidth, oldPanelHeight;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            shape = new LineShape();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            shape = new RectShape();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shape = new EllipseShape();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            red = redTrackBar.Value;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            green = greenTrackBar.Value;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            blue = blueTrackBar.Value;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;

            if (bg == null) {
                oldPanelHeight = panel1.Height;
                oldPanelWidth = panel1.Width;
                bg = new Bitmap(panel1.Width, panel1.Height);
                fg = new Bitmap(panel1.Width, panel1.Height);
                bgg = Graphics.FromImage(bg);
                bgg.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);
                fgg = Graphics.FromImage(fg);
            }

            startX = e.X;
            startY = e.Y;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (bg == null) return;

            if (panel1.Width > oldPanelWidth && panel1.Height > oldPanelHeight)
            {
                oldPanelWidth = panel1.Width;
                oldPanelHeight = panel1.Height;
                Bitmap copy = new Bitmap(bg);
                bg = new Bitmap(panel1.Width, panel1.Height);
                bgg = Graphics.FromImage(bg);
                bgg.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);
                fg = new Bitmap(panel1.Width, panel1.Height);
                fgg = Graphics.FromImage(fg);
                bgg.DrawImageUnscaled(copy, new Rectangle(0, 0, copy.Width, copy.Height));
                Graphics g = panel1.CreateGraphics();
                g.DrawImage(bg, 0, 0);
            }
            else {
                bgg.DrawImageUnscaled(bg, new Rectangle(0,0,bg.Width,bg.Height));
                Graphics g = panel1.CreateGraphics();
                g.DrawImage(bg, 0, 0);
            }
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (down) {
                fgg.DrawImageUnscaled(bg, new Rectangle(0,0, fg.Width, fg.Height));
                Pen pen = new Pen(Color.FromArgb(red, green, blue));
                endX = e.X;
                endY = e.Y;
                shape.DrawColoredShape(fgg, pen, startX, startY, endX, endY);
                Graphics g = panel1.CreateGraphics();
                g.DrawImage(fg, 0, 0);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
            bgg.DrawImageUnscaled(fg, new Rectangle(0,0,bg.Width,bg.Height));
            
        }

    }
}
