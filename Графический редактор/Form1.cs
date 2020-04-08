using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CtrLibrary;

namespace Графический_редактор
{
    public partial class Form1 : Form
    {
        private int Mx, My, Sw, Sh;
        private bool moveResize, isCollapse;

        private Size resolution;
        private Point prevPoint;
        private Point MouseHook;
        private Layer layers;
        private Button selectedTool;
        private Pen pen;
        private Tool tool;

        public Form1()
        {
            InitializeComponent();

            isCollapse = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            resolution = Size;
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            selectedTool = butBrush;
            ToolChange_Click(selectedTool, null);
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
        private void SizerMouseMove(object sender, MouseEventArgs e)
        {
            var panel = (Panel)sender;
            if (moveResize && isCollapse)
            {
                if (panel == panelResizeALL)
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
        private void SizerMouseUp(object sender, MouseEventArgs e) => moveResize = false;
        private void butLayerUp_Click(object sender, EventArgs e) => layers.Up();
        private void butLayerDown_Click(object sender, EventArgs e) => layers.Down();
        private void button1_Click(object sender, EventArgs e) => Close();
        private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
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
            var PictureDialog = new CreatePictureDialog();
            PictureDialog.TopMost = true;
            PictureDialog.ShowDialog();
            if (PictureDialog.Cancel) return;

            layers = new Layer(ref listView1, PanelForDraw.Size, PictureDialog.picSize);

            PanelForDraw.Controls.Clear();
            PanelForDraw.Controls.Add(layers.Picture);

            layers.Top.MouseDown += new MouseEventHandler(Picture_MouseDown);
            layers.Top.MouseMove += new MouseEventHandler(Picture_MouseMove);
            layers.Top.MouseUp += new MouseEventHandler(Picture_MouseUp);

            layers.Add();
            layers.Fill(Color.White);
            layers.Change();

            menuItemSaveFile.Enabled = true;
            butLayerUp.Enabled = true;
            butLayerDown.Enabled = true;
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint.X = e.X;
            prevPoint.Y = e.Y;
            layers.Change();

            if (tool.Name == NameTool.Brush) pen = ((Brush)tool).GetPen();
            if (tool.Name == NameTool.Eraser) pen = ((Eraser)tool).GetPen();
            if (tool.Name == NameTool.Fill)
            {
                Fill(e.X, e.Y, ((PaintBasket)tool).GetPen());
                pen = ((PaintBasket)tool).GetPen();
            }

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
        }
        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            layers.Update();
            layers.Change();
            layers.ViewUpdata();
        }
        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            listView1.Select();
            if (layers.Count == 0) return;
            int LX = Math.Abs(prevPoint.X - e.X);
            int LY = Math.Abs(prevPoint.Y - e.Y);

            if (e.Button == MouseButtons.Left && layers.Visible && tool.Name == NameTool.Brush)
            {
                using (Graphics graph = Graphics.FromImage(layers[layers.Number]))
                {
                    //graph.SmoothingMode = SmoothingMode.AntiAlias;
                    graph.DrawLine(pen, prevPoint.X, prevPoint.Y, e.X, e.Y);
                }

                layers.Update();
            }

            if (e.Button == MouseButtons.Left && layers.Visible && tool.Name == NameTool.Eraser)
            {
                using (Graphics graph = Graphics.FromImage(layers[layers.Number]))
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    graph.CompositingMode = CompositingMode.SourceCopy;
                    graph.DrawLine(pen, prevPoint.X, prevPoint.Y, e.X, e.Y);
                }

                layers.Update();
            }
            prevPoint.X = e.X;
            prevPoint.Y = e.Y;
        }

        private void Fill(int x, int y, Pen pen)
        {
            if (x < 1 || x > layers.Width || y < 1 || y > layers.Height)
                return;

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            Bitmap tempBmp = layers[layers.Number];
            Color old_color, new_color;
            new_color = pen.Color;
            old_color = tempBmp.GetPixel(x, y);


            if (old_color == new_color)
                return;

            List<Point> p = new List<Point>();
            p.Add(new Point(x, y));

            int Ntek = 0;
            Graphics g = Graphics.FromImage(tempBmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            do
            {
                if (p[Ntek].X + 1 < layers.Width)
                {
                    if (tempBmp.GetPixel(p[Ntek].X + 1, p[Ntek].Y) == old_color)
                    {
                        p.Add(new Point(p[Ntek].X + 1, p[Ntek].Y));
                        tempBmp.SetPixel(p[Ntek].X + 1, p[Ntek].Y, new_color);
                    }
                }
                if (p[Ntek].X - 1 >= 0)
                {
                    if (tempBmp.GetPixel(p[Ntek].X - 1, p[Ntek].Y) == old_color)
                    {
                        p.Add(new Point(p[Ntek].X - 1, p[Ntek].Y));
                        tempBmp.SetPixel(p[Ntek].X - 1, p[Ntek].Y, new_color);
                    }
                }
                if (p[Ntek].Y + 1 < layers.Height)
                {
                    if (tempBmp.GetPixel(p[Ntek].X, p[Ntek].Y + 1) == old_color)
                    {
                        p.Add(new Point(p[Ntek].X, p[Ntek].Y + 1));
                        tempBmp.SetPixel(p[Ntek].X, p[Ntek].Y + 1, new_color);
                    }
                }
                if (p[Ntek].Y - 1 >= 0)
                {
                    if (tempBmp.GetPixel(p[Ntek].X, p[Ntek].Y - 1) == old_color)
                    {
                        p.Add(new Point(p[Ntek].X, p[Ntek].Y - 1));
                        tempBmp.SetPixel(p[Ntek].X, p[Ntek].Y - 1, new_color);
                    }
                }
                Ntek++;
            } while (Ntek < p.Count - 1);

            layers[layers.Number] = tempBmp;

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.bmp, *.jpg, *.png) | *.bmp; *.jpg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog.FileName);

                layers = new Layer(ref listView1, PanelForDraw.Size, new Bitmap(PanelForDraw.Width, PanelForDraw.Height).ImageZoom(image).Size);

                PanelForDraw.Controls.Clear();
                PanelForDraw.Controls.Add(layers.Picture);

                layers.Top.MouseDown += new MouseEventHandler(Picture_MouseDown);
                layers.Top.MouseMove += new MouseEventHandler(Picture_MouseMove);
                layers.Top.MouseUp += new MouseEventHandler(Picture_MouseUp);

                layers.Add();
                layers.Middle.Image = layers[0].ImageZoom(image);
                layers.Middle.Image = layers[0].ImageZoom(image);
                layers.Change();

                menuItemSaveFile.Enabled = true;
                butLayerUp.Enabled = true;
                butLayerDown.Enabled = true;
            }
        }

        private void IndexChange(object sender, EventArgs e)
        {
            if (!(listView1.SelectedIndices.Count > 0)) return;
            int index = listView1.SelectedIndices[0];
            layers.Number = index;
        }

        private void ToolChange_Click(object sender, EventArgs e)
        {
            selectedTool.BackColor = Color.FromArgb(38, 38, 38);
            selectedTool = (Button)sender;
            selectedTool.BackColor = Color.FromArgb(25, 25, 25);

            switch (selectedTool.Name)
            {
                case "butBrush": tool = new Brush(); break;
                case "butEraser": tool = new Eraser(); break;
                case "butFill": tool = new PaintBasket(); break;
            }
            tool.SetSettings(ref panelTools);
        }

        private void butNewLayer_Click(object sender, EventArgs e)
        {
            if (layers == null) return;
            layers.Add();
            menuItemSaveFile.Enabled = true;
        }

        private void butDeleteLayer_Click(object sender, EventArgs e)
        {
            if (layers == null) return;
            layers.RemoveAt(layers.Number);
            if (layers.Count == 0) menuItemSaveFile.Enabled = false;
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (layers == null) return;
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
                List<Bitmap> temp = layers.GetBitmap();
                temp.Reverse();

                if (fileExtension == ".jpg")
                {

                    var bmp = new Bitmap(layers.Width, layers.Height);
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
            if (layers == null) return;
            layers.Visible = !layers.Visible;
            layers.Change();
            layers.ViewUpdata();
        }
    }
}
