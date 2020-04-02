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
        private PictureBox currentPic, topPic, buttomPic;
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
        private PictureBox PictureBoxCreate(Size _size)
        {
            Bitmap temp = new Bitmap(PanelForDraw.Width, PanelForDraw.Height);
            if (_size.Width > PanelForDraw.Width && _size.Height > PanelForDraw.Height)
                temp = temp.ImageZoom(new Bitmap(_size.Width, _size.Height));
            else
                temp = new Bitmap(_size.Width, _size.Height);
            var picture = new PictureBox();
            picture.BackColor = Color.FromArgb(0, 0, 0, 0);
            picture.Size = temp.Size;
            picture.Location = new Point((PanelForDraw.Width - picture.Size.Width) / 2, (PanelForDraw.Height - picture.Size.Height) / 2);
            picture.MouseMove += new MouseEventHandler(Picture_MouseMove);
            picture.MouseUp += new MouseEventHandler(Picture_MouseUp);
            //picture.Paint += new PaintEventHandler(Picture_Paint);

            bitmaps.Clear();
            listBox1.Items.Clear();
            bitmaps.Add(new Bitmap(picture.Width, picture.Height));
            listBox1.Items.Add("Cлой: " + bitmaps.Count);

            return picture;
        }
        private void Picture_Paint()
        {
            Bitmap bitmap = GraphicsExtension.CombineBitmap(ref bitmaps);
            currentPic.Image = bitmap;
  
        }
        private void CreatePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PictureDialog = new CreatePictureDialog();
            PictureDialog.TopMost = true;
            PictureDialog.ShowDialog();
            if (PictureDialog.Cancel) return;

            currentPic = PictureBoxCreate(PictureDialog.picSize);
            topPic = PictureBoxCreate(PictureDialog.picSize);
            buttomPic = PictureBoxCreate(PictureDialog.picSize);

            PanelForDraw.Controls.Clear();
            PanelForDraw.Controls.Add(currentPic);
            PanelForDraw.Controls.Add(buttomPic);

            currentPic.Controls.Add(topPic);

            currentPic.Location = currentPic.Location;
            topPic.Location = new Point(0, 0);
            buttomPic.Location = new Point(0, currentPic.Height / 2  + 10);


            buttomPic.BackColor = Color.FromArgb(10, 0, 255, 0);
            currentPic.BackColor = Color.White;
            topPic.BackColor = Color.FromArgb(50, 0, 0, 255);

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
                currentPic.Image = bitmaps[index];
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
                currentPic = topPic = buttomPic = PictureBoxCreate(new Bitmap(PanelForDraw.Width, PanelForDraw.Height).ImageZoom(image).Size);

                currentPic.Image = bitmaps[bitmaps.Count - 1].ImageZoom(image);
                currentPic.Image = bitmaps[bitmaps.Count - 1];


                PanelForDraw.Controls.Clear();
                PanelForDraw.Controls.Add(buttomPic);
                PanelForDraw.Controls.Add(currentPic);
                PanelForDraw.Controls.Add(topPic);
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
