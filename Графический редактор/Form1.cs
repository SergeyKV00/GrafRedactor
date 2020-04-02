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

namespace Графический_редактор
{
    public partial class Form1 : Form
    {
        //private PictureBox currentPic, topPic, buttomPic;
        private Canvas canvas;
        private Point prevPoint;
        private List<Bitmap> bitmaps;
        private bool isCollapse;

        public Form1()
        {
            InitializeComponent();
            bitmaps = new List<Bitmap>();
            isCollapse = false;
        }
        private void button1_Click(object sender, EventArgs e) => Close();
        private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void button3_Click(object sender, EventArgs e)
        {
            if (isCollapse)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
            isCollapse = !isCollapse;
        } 
        private void Picture_Paint()
        {
            Bitmap bitmap = GraphicsExtension.CombineBitmap(ref bitmaps);
            canvas.CurrentPic.Image = bitmap;
  
        }
        private void CreatePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PictureDialog = new CreatePictureDialog();
            PictureDialog.TopMost = true;
            PictureDialog.ShowDialog();
            if (PictureDialog.Cancel) return;

            canvas = new Canvas(ref PanelForDraw,PictureDialog.picSize);

            canvas.CurrentPic.MouseMove += new MouseEventHandler(Picture_MouseMove);
            canvas.CurrentPic.MouseUp += new MouseEventHandler(Picture_MouseUp);

            bitmaps.Clear();
            listBox1.Items.Clear();
            bitmaps.Add(new Bitmap(canvas.CanvasSize.Width, canvas.CanvasSize.Height));
            listBox1.Items.Add("Cлой: " + bitmaps.Count);

        }

        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            Pen p = new Pen(Color.Red);
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.Round;

            Graphics graph = Graphics.FromImage(bitmaps[index]);

            if (e.Button == MouseButtons.Left)
            {
                graph.DrawLine(p, prevPoint.X, prevPoint.Y, e.X, e.Y);
                canvas.CurrentPic.Image = bitmaps[index];
            }

            prevPoint.X = e.X;
            prevPoint.Y = e.Y;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.bmp, *.jpg, *.png) | *.bmp; *.jpg; *.png";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                canvas = new Canvas(ref PanelForDraw, new Bitmap(PanelForDraw.Width, PanelForDraw.Height).ImageZoom(image).Size);

                canvas.CurrentPic.Image = bitmaps[bitmaps.Count - 1].ImageZoom(image);
                canvas.CurrentPic.Image = bitmaps[bitmaps.Count - 1];

                bitmaps.Clear();
                listBox1.Items.Clear();
                bitmaps.Add(new Bitmap(canvas.CanvasSize.Width, canvas.CanvasSize.Height));
                listBox1.Items.Add("Cлой: " + bitmaps.Count);
            }
        }

        private void butNewLayer_Click(object sender, EventArgs e)
        {
            if (bitmaps.Count == 0) return;
            bitmaps.Add(new Bitmap(bitmaps[0].Width, bitmaps[0].Height));
            listBox1.Items.Add("Cлой: " + bitmaps.Count);
        }

        private void butDeleteLayer_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index != -1)
            {
                listBox1.Items.RemoveAt(index);
                bitmaps.RemoveAt(index);
            }
            Picture_Paint();
        }
    }
}
