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
        private int indexClear = -1;

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

            canvas.TopPic.MouseMove += new MouseEventHandler(Picture_MouseMove);
            //canvas.TopPic.MouseUp += new MouseEventHandler(Picture_MouseUp);
            canvas.TopPic.MouseDown += new MouseEventHandler(Picture_MouseDown);

            bitmaps.Clear();
            listBox1.Items.Clear();
            bitmaps.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));
            Graphics graph = Graphics.FromImage(bitmaps[0]);
            graph.FillPngBackground(canvas.Size.Width, canvas.Size.Height);

            bitmaps.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));
            Graphics.FromImage(bitmaps[1]).FillRectangle(new SolidBrush(Color.White), 0, 0, canvas.Size.Width, canvas.Size.Height);

            canvas.ButtomPic.Image = bitmaps[1];
            listBox1.Items.Add("Cлой: " + (bitmaps.Count - 1));

        }

        /*private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            canvas.CurrentPic.Image = null;
            Picture_MouseDown(sender, e);
        }*/

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1 || bitmaps.Count < 2) return;

            List<Bitmap> tempBitmaps = new List<Bitmap>();
            for (int i = 0; i < index; i++)
                tempBitmaps.Add(bitmaps[i]);

            if(tempBitmaps.Count > 0)
                canvas.ButtomPic.Image = GraphicsExtension.CombineBitmap(ref tempBitmaps);

            tempBitmaps.Clear();
            for (int i = index + 1; i < bitmaps.Count; i++)
                tempBitmaps.Add(bitmaps[i]);

            if (tempBitmaps.Count > 0)
                canvas.TopPic.Image = GraphicsExtension.CombineBitmap(ref tempBitmaps);
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
