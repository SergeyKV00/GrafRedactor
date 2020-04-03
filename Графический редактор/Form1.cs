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
        private Layer layer;
        private bool isCollapse;

        public Form1()
        {
            InitializeComponent();
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
        private void CreatePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PictureDialog = new CreatePictureDialog();
            PictureDialog.TopMost = true;
            PictureDialog.ShowDialog();
            if (PictureDialog.Cancel) return;

            canvas = new Canvas(ref PanelForDraw,PictureDialog.picSize);

            canvas.TopPic.MouseMove += new MouseEventHandler(Picture_MouseMove);
            canvas.TopPic.MouseUp += new MouseEventHandler(Picture_MouseUp);
            canvas.TopPic.MouseDown += new MouseEventHandler(Picture_MouseDown);

            layer = new Layer(listBox1, new Bitmap(canvas.Size.Width, canvas.Size.Height), true);
            layer.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));

            canvas.ButtomPic.Image = layer[1];
            var tempBmp = layer[0];
            Graphics.FromImage(tempBmp).FillRectangle(new SolidBrush(Color.White), 0, 0, tempBmp.Width, tempBmp.Height);
            canvas.CurrentPic.Image = layer[0] = tempBmp;

            listBox1.SetSelected(0, true);
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e) => layer.Redrawing(ref canvas);
        private void Picture_MouseUp(object sender, MouseEventArgs e) => layer.Redrawing(ref canvas);

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;

            var tempBmp = layer[index];
            Graphics graph = Graphics.FromImage(tempBmp);

            if (e.Button == MouseButtons.Left && layer.tryVisible(index))
            {
                Pen p = new Pen(Color.Red, 15);
                p.StartCap = LineCap.Round;
                p.EndCap = LineCap.Round;
                graph.DrawLine(p, prevPoint.X, prevPoint.Y, e.X, e.Y);
                layer[index] = tempBmp;
                canvas.CurrentPic.Image = layer[index];

            }

            if (e.Button == MouseButtons.Right && layer.tryVisible(index))
            {
                Pen p = new Pen(Color.Blue, 15);
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.bmp, *.jpg, *.png) | *.bmp; *.jpg; *.png";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog.FileName);
                canvas = new Canvas(ref PanelForDraw, new Bitmap(PanelForDraw.Width, PanelForDraw.Height).ImageZoom(image).Size);

                canvas.TopPic.MouseMove += new MouseEventHandler(Picture_MouseMove);
                canvas.TopPic.MouseUp += new MouseEventHandler(Picture_MouseUp);
                canvas.TopPic.MouseDown += new MouseEventHandler(Picture_MouseDown);

                layer = new Layer(listBox1, new Bitmap(canvas.Size.Width, canvas.Size.Height), true);
                layer.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));

                canvas.ButtomPic.Image = layer[0].ImageZoom(image);
                canvas.ButtomPic.Image = layer[0];

                listBox1.SetSelected(0, true);

                layer.Redrawing(ref canvas);
            }
        }

        private void butNewLayer_Click(object sender, EventArgs e)
        {
            if (layer == null) return;

            if (layer.Count == 0) return;
            layer.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));
        }

        private void butDeleteLayer_Click(object sender, EventArgs e)
        {
            if (layer == null) return;
            int index = listBox1.SelectedIndex;
            if(index != -1)
            {
                layer.RemoveAt(index);
                canvas.Clear();
                var temp = layer[layer.Count - 1];
                Graphics graph = Graphics.FromImage(temp);
                graph.FillPngBackground(canvas.Size.Width, canvas.Size.Height);
                canvas.ButtomPic.Image = temp;
            }
            if (listBox1.Items.Count != 0) listBox1.SetSelected(listBox1.Items.Count - 1, true);
            layer.Redrawing(ref canvas);
        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Filter =
            "PNG File(*.png)|*.png" +
            "JPEG File(*.jpg)|*.jpg|" +
            "Bitmap File(*.bmp)|*.bmp|" +
            "TIF File(*.tif)|*.tif|";
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                var temp = layer.Bitmaps;
                temp.Reverse();
                Bitmap saveB = GraphicsExtension.CombineBitmap(ref temp);
                saveB.Save(savedialog.FileName);
            }
        }

        private void button_HidenLayer(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1 || layer == null) return;
            layer.Visible(index);

            canvas.Clear();
            var temp = layer[layer.Count - 1];
            Graphics graph = Graphics.FromImage(temp);
            graph.FillPngBackground(canvas.Size.Width, canvas.Size.Height);
            canvas.ButtomPic.Image = temp;

            layer.Redrawing(ref canvas);
        }
    }
}
