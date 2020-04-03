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
        private Canvas canvas;
        private Point prevPoint;
        private List<Bitmap> bitmaps;
        Layer layer;
        private bool isCollapse;

        public Form1()
        {
            InitializeComponent();
            bitmaps = new List<Bitmap>(); // complete
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
            var temp = layer.Bitmaps;
            Bitmap bitmap = GraphicsExtension.CombineBitmap(ref temp); // work
            canvas.CurrentPic.Image = bitmap;
  
        }
        private void CreatePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PictureDialog = new CreatePictureDialog();
            PictureDialog.TopMost = true;
            PictureDialog.ShowDialog();
            if (PictureDialog.Cancel) return;

            canvas = new Canvas(ref PanelForDraw,PictureDialog.picSize);

            canvas.TopPic.MouseMove += new MouseEventHandler(Picture_MouseMove);
            //canvas.TopPic.MouseUp += new MouseEventHandler(Picture_MouseUp);
            canvas.TopPic.MouseDown += new MouseEventHandler(Picture_MouseDown);

            layer = new Layer(listBox1, new Bitmap(canvas.Size.Width, canvas.Size.Height), true);
            layer.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));

            canvas.ButtomPic.Image = layer[1];
            var tempBmp = layer[0];
            Graphics.FromImage(tempBmp).FillRectangle(new SolidBrush(Color.White), 0, 0, tempBmp.Width, tempBmp.Height);
            canvas.CurrentPic.Image = layer[0] = tempBmp;
        }

        /*private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            canvas.CurrentPic.Image = null;
            Picture_MouseDown(sender, e);
        }*/

        private void Picture_MouseDown(object sender, MouseEventArgs e) => layer.SpreadLayersOnCanvas(ref canvas);

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;

            var tempBmp = layer[index];
            Graphics graph = Graphics.FromImage(tempBmp);

            if (e.Button == MouseButtons.Left)
            {
                Pen p = new Pen(Color.Red);
                p.StartCap = LineCap.Round;
                p.EndCap = LineCap.Round;
                graph.DrawLine(p, prevPoint.X, prevPoint.Y, e.X, e.Y);
                layer[index] = tempBmp;
                canvas.CurrentPic.Image = layer[index];

            }

            if (e.Button == MouseButtons.Right)
            {
                Pen p = new Pen(Color.Blue);
                p.StartCap = LineCap.Round;
                p.EndCap = LineCap.Round;
                graph.DrawLine(p, prevPoint.X, prevPoint.Y, e.X, e.Y);
                layer[index] = tempBmp;
                canvas.CurrentPic.Image = layer[index];
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

                canvas.TopPic.MouseMove += new MouseEventHandler(Picture_MouseMove);
                canvas.TopPic.MouseDown += new MouseEventHandler(Picture_MouseDown);

                bitmaps.Clear();
                listBox1.Items.Clear();
                bitmaps.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));
                listBox1.Items.Add("Cлой: " + bitmaps.Count);

                canvas.ButtomPic.Image = bitmaps[bitmaps.Count - 1].ImageZoom(image);
                canvas.ButtomPic.Image = bitmaps[bitmaps.Count - 1];
            }
        }

        private void butNewLayer_Click(object sender, EventArgs e)
        {
            if (layer.Count == 0) return;
            //bitmaps.Add(new Bitmap(bitmaps[0].Width, bitmaps[0].Height));
            //listBox1.Items.Add("Cлой: " + bitmaps.Count);
            layer.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));
        }

        private void butDeleteLayer_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index != -1)
            {
                layer.RemoveAt(index);
            }
            Picture_Paint();
        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Filter =
            "Bitmap File(*.bmp)|*.bmp|" +
            "JPEG File(*.jpg)|*.jpg|" +
            "TIF File(*.tif)|*.tif|" +
            "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap saveB = GraphicsExtension.CombineBitmap(ref bitmaps);
                saveB.Save(savedialog.FileName);
            }
        }
    }
}
