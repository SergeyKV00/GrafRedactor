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
        private int Mx, My, Sw, Sh;
        private bool moveResize, isCollapse, isEraser;

        private Size resolution;
        private Canvas canvas;
        private Point prevPoint;
        private Point MouseHook;
        private Layer layer;
       
        public Form1()
        {
            InitializeComponent();

            isCollapse = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            resolution = Size;
            this.Size = Screen.PrimaryScreen.Bounds.Size;
        }
        
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isCollapse) return;
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
        private void SizerMouseDown(object sender, MouseEventArgs e)
        {
            moveResize = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }
        void SizerMouseMove(object sender, MouseEventArgs e)
        {
            var panel = (Panel)sender;
            if (moveResize && isCollapse)
            {
                if(panel == panelResizeALL)
                {
                    Width = MousePosition.X - Mx + Sw;
                    Height = MousePosition.Y - My + Sh;
                }
                if (panel == panelResizeX)
                    Width = MousePosition.X - Mx + Sw;
                if (panel == panelResizeY)
                    Height = MousePosition.Y - My + Sh;
            }
        }
        void SizerMouseUp(object sender, MouseEventArgs e) => moveResize = false;
        private void button1_Click(object sender, EventArgs e) => Close();
        private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void barWidthPen_Scroll(object sender, EventArgs e) => labelWidthPen.Text = barWidthPen.Value.ToString();
        private void button3_Click(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panelResizeALL.Cursor = Cursors.Default;
                panelResizeX.Cursor = Cursors.Default;
                panelResizeY.Cursor = Cursors.Default;
                this.Size = Screen.PrimaryScreen.Bounds.Size;
                Location = new Point(0, 0);
            }              
            else
            {
                panelResizeALL.Cursor = Cursors.SizeNWSE;
                panelResizeX.Cursor = Cursors.SizeWE;
                panelResizeY.Cursor = Cursors.SizeNS;
                
                this.Size = resolution;
            }
                
            isCollapse = !isCollapse;
        } 
        private void CreatePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // === Открыть диалок созданий холста ====
            var PictureDialog = new CreatePictureDialog();
            PictureDialog.TopMost = true;
            PictureDialog.ShowDialog();
            if (PictureDialog.Cancel) return; // Отмена создания холста
            // === === === === === === === === === ===
            // === Создание холста ===
            canvas = new Canvas(ref PanelForDraw,PictureDialog.picSize);
            canvas.TopPic.MouseMove += new MouseEventHandler(Picture_MouseMove);
            canvas.TopPic.MouseUp += new MouseEventHandler(Picture_MouseUp);
            canvas.TopPic.MouseDown += new MouseEventHandler(Picture_MouseDown);
            // === === === === === ===

            layer = new Layer(listBox1, new Bitmap(canvas.Size.Width, canvas.Size.Height), true);
            layer.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));

            canvas.ButtomPic.Image = layer[1];
            var tempBmp = layer[0];
            Graphics.FromImage(tempBmp).FillRectangle(new SolidBrush(Color.White), 0, 0, tempBmp.Width, tempBmp.Height);
            canvas.CurrentPic.Image = layer[0] = tempBmp;
            listBox1.SetSelected(0, true);


            menuItemSaveFile.Enabled = true;
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e) => layer.Redrawing(ref canvas);
        private void Picture_MouseUp(object sender, MouseEventArgs e) => layer.Redrawing(ref canvas);

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;

            var tempBmp = layer[index];
            Graphics graph = Graphics.FromImage(tempBmp);

            Pen p = new Pen(butColor1.BackColor, barWidthPen.Value);
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.Round;

            if (e.Button == MouseButtons.Left && layer.tryVisible(index))
            {           
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
                menuItemSaveFile.Enabled = true;
            }
        }

        private void ColorAction_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            try
            {
                var temp = (Panel)sender;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    temp.BackColor = colorDialog.Color;
            }
            catch
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    butColor1.BackColor = colorDialog.Color;
            }         
        }

        private void ColorChange_Click(object sender, EventArgs e)
        {
            var tmpColor = butColor1.BackColor;
            butColor1.BackColor = butColor2.BackColor;
            butColor2.BackColor = tmpColor;
        }

        private void butEraser_Click(object sender, EventArgs e)
        {
            isEraser = !isEraser;
        }

        private void butNewLayer_Click(object sender, EventArgs e)
        {
            if (layer == null) return;

            if (layer.Count == 0) return;
            layer.Add(new Bitmap(canvas.Size.Width, canvas.Size.Height));
            listBox1.SetSelected(0, true);

            menuItemSaveFile.Enabled = true;
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
                if(layer.Count == 1) menuItemSaveFile.Enabled = false;
            }
            if (listBox1.Items.Count != 0) listBox1.SetSelected(listBox1.Items.Count - 1, true);
            layer.Redrawing(ref canvas);
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (layer == null)
            {
            }
            if (layer.Count == 0) return;
            SaveFileDialog savedialog = new SaveFileDialog
            {
                Filter =
            "Bitmap File(*.bmp)|*.bmp|" +
            "JPEG File(*.jpg)|*.jpg|" +
            "TIF File(*.tif)|*.tif|" +
            "PNG File(*.png)|*.png",
                ShowHelp = true
            };
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileExtension = System.IO.Path.GetExtension(savedialog.FileName);
                var temp = layer.Bitmaps;
                temp.Reverse();
                temp.RemoveAt(0);

                if(fileExtension == ".fpg")
                {
                    var bmp = new Bitmap(canvas.Size.Width, canvas.Size.Height);
                    var graph = Graphics.FromImage(bmp);
                    graph.FillRectangle(new SolidBrush(Color.White), 0, 0, bmp.Width, bmp.Height);
                    temp.Insert(0, bmp);
                }

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
