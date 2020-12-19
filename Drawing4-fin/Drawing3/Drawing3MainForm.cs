using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing3
{
    public partial class Drawing3MainForm : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 5);
        public Pen pe = new Pen(Color.White, 5);
        public int width;
        static Bitmap surface;
        static SynchronizedGraphics g = new SynchronizedGraphics();
        bool saved = true;
        String saveFile = null;
        public Drawing3MainForm()
        {
            InitializeComponent();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            pe.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            surface = new Bitmap(drawingPanel.Width, drawingPanel.Height, PixelFormat.Format24bppRgb);

            p.Width = 1;
            pe.Width = 1;

            g.panelGraphics = drawingPanel.CreateGraphics();
            g.surfaceGraphics = Graphics.FromImage(surface);

            g.clear();
        }

        private class SynchronizedGraphics
        {
            public Graphics panelGraphics;
            public Graphics surfaceGraphics;

            public void DrawLine(Pen pen, Point p1, Point p2)
            {
                panelGraphics.DrawLine(pen, p1, p2);
                surfaceGraphics.DrawLine(pen, p1, p2);
            }

            public void DrawImage(Bitmap image, Point loc)
            {
                panelGraphics.DrawImage(image, loc);
                surfaceGraphics.DrawImage(image, loc);
            }

            public void clear()
            {
                panelGraphics.Clear(Color.White);
                surfaceGraphics.Clear(Color.White);
            }
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        Bitmap lineTempImage;
        bool hasLine = false;

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                if (Control.ModifierKeys == Keys.Shift)
                {
                    if (!hasLine)
                    {
                        hasLine = true;
                        lineTempImage = surface.Clone(new Rectangle(0, 0, surface.Width, surface.Height), PixelFormat.Format24bppRgb);
                    }
                    g.panelGraphics.DrawImage(lineTempImage, Point.Empty);
                    g.panelGraphics.DrawLine(p, old, current);
                }
                else
                {
                    if (hasLine)
                    {
                        g.DrawImage(lineTempImage, Point.Empty);
                        hasLine = false;
                    }
                    current = e.Location;
                    g.DrawLine(p, old, current);
                    old = current;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                current = e.Location;
                g.DrawLine(pe, old, current);
                old = current;
            }
            saved = false;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                p.Color = cd.Color;
                colorPreview.BackColor = cd.Color;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            g.clear();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ReloadImage();
        }

        private void WidthSlider_Scroll(object sender, EventArgs e)
        {
            p.Width = Math.Max((widthSlider.Value - 1) * 5, 1);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                if (saveFile == null)
                {
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        surface.Save(saveDialog.FileName, ImageFormat.Png);
                    }
                }
                else
                {
                    surface.Save(saveFile, ImageFormat.Png);
                }
                saved = true;
            }
        }

        private void EraserWidthSlider_Scroll(object sender, EventArgs e)
        {
            pe.Width = Math.Max((eraserWidthSlider.Value - 1) * 5, 1);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ReloadImage();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Image png = Image.FromFile(openDialog.FileName);
                surface = new Bitmap(png);
                ReloadImage();
            }
        }

        private void ReloadImage()
        {
            g.panelGraphics = drawingPanel.CreateGraphics();
            g.panelGraphics.DrawImage(surface, Point.Empty);
        }

        private void Drawing3MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                var window = MessageBox.Show(
                    "Do you want to keep the changes?",
                    "Save?",
                    MessageBoxButtons.YesNoCancel);

                if (window == DialogResult.Yes)
                {
                    BtnSave_Click(null, null);
                }

                e.Cancel = (window == DialogResult.Cancel);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (hasLine)
            {
                g.DrawLine(p, old, current);
                hasLine = false;
            }
        }

        private void Drawing3MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}