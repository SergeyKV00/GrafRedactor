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

namespace Графический_редактор
{
    public partial class Form1 : Form
    {
        private int Mx, My, Sw, Sh;
        private bool moveResize, isCollapse;

        private Size resolution;
        private Point prevPoint, mouseHook, mouseClickPoint;
        private Layer layers;
        private Button selectedTool;
        private Pen pen;
        private ToolSetting tool;
        private Dictionary<NameTool, object[]> toolSettingValues;
        private Dictionary<Keys, bool> activeKeys;

        public Form1()
        {
            InitializeComponent();

            isCollapse = false;
            this.KeyPreview = true;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            resolution = Size;
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            selectedTool = butBrush;
            toolSettingValues = new Dictionary<NameTool, object[]>();
            tool = new BrushSetting();
            ToolChange_Click(selectedTool, null);

            activeKeys = new Dictionary<Keys, bool>
            {
                { Keys.Shift, false }
            };
        }
        // ==================== //
        #region Настройки формы

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isCollapse) return;
            if (e.Button != MouseButtons.Left) mouseHook = e.Location;
            Location = new Point((Size)Location - (Size)mouseHook + (Size)e.Location);
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

        #endregion
        // ==================== //

        // Создание холста
        private void CreatePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PictureDialog = new CreatePictureDialog();
            PictureDialog.TopMost = true;
            PictureDialog.ShowDialog();
            if (PictureDialog.Cancel) return;

            layers = new Layer(ref listView1, PanelForDraw.Size, PictureDialog.picSize);

            PanelForDraw.Controls.Clear();
            PanelForDraw.Controls.Add(layers.Picture);

            layers.MouseCanvas.MouseDown += new MouseEventHandler(Picture_MouseDown);
            layers.MouseCanvas.MouseMove += new MouseEventHandler(Picture_MouseMove);
            layers.MouseCanvas.MouseUp += new MouseEventHandler(Picture_MouseUp);

            layers.Add();
            layers.Fill(Color.White);
            layers.Change();
            ToolChange_Click(selectedTool, null);

            menuItemSaveFile.Enabled = true;
            butLayerUp.Enabled = true;
            butLayerDown.Enabled = true;
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (layers.Count == 0) return;
            prevPoint.X = e.X;
            prevPoint.Y = e.Y;
            mouseClickPoint.X = e.X;
            mouseClickPoint.Y = e.Y;
            layers.Change();

            if (tool.Name == NameTool.Line) pen = ((LineSetting)tool).GetPen();
            if (tool.Name == NameTool.Fill)
            {
                Fill(e.X, e.Y, ((FillSetting)tool).GetPen());
                pen = ((FillSetting)tool).GetPen();
            }

        }
        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (layers.Count == 0) return;
            if (tool.Name == NameTool.Line && e.Button == MouseButtons.Left && layers.Visible)
            {
                using (Graphics graph = Graphics.FromImage(layers[layers.Number]))
                {
                    graph.DrawLine(pen, mouseClickPoint.X, mouseClickPoint.Y, e.X, e.Y);
                }
            }
            layers.Update();
            layers.Change();
            layers.ViewUpdata();
        }
        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            listView1.Select();
            if (layers.Count == 0) return;

            if (tool.Name == NameTool.Brush) pen = ((BrushSetting)tool).GetPen();
            if (tool.Name == NameTool.Eraser) pen = ((EraserSetting)tool).GetPen();

            if (pen != null)
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
            }

            if (e.Button == MouseButtons.Left && layers.Visible && tool.Name == NameTool.Brush)
            {
                using (Graphics graph = Graphics.FromImage(layers[layers.Number]))
                {
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

            if (e.Button == MouseButtons.Left && layers.Visible && tool.Name == NameTool.Line)
            {
                Bitmap tempLineBmp = new Bitmap(layers.Width, layers.Height);
                using (Graphics graph = Graphics.FromImage(tempLineBmp))
                {
                    if (activeKeys[Keys.Shift])
                    {
                        float distance = (mouseClickPoint.Y - e.Y) / (float)(mouseClickPoint.X - e.X);
                        float angle = (float)Math.Atan(distance) * (float)(180 / Math.PI);
                        int intAngle = (int)Math.Abs(Math.Round(angle, 4));
                        labelAngle.Text = intAngle.ToString();
                        if (intAngle == 90 || intAngle == 45 || intAngle == 0)
                            graph.DrawLine(new Pen(Color.Black), mouseClickPoint.X, mouseClickPoint.Y, e.X, e.Y);

                    }
                    else
                        graph.DrawLine(new Pen(Color.Black), mouseClickPoint.X, mouseClickPoint.Y, e.X, e.Y);
                    layers.MouseCanvas.Image = tempLineBmp;
                }
            }

            if (tool.Name != NameTool.Fill && tool.Name != NameTool.Line)
            {
                Bitmap tempBmp = new Bitmap(layers.Width, layers.Height);
                using (Graphics graph = Graphics.FromImage(tempBmp))
                {
                    graph.DrawEllipse(new Pen(Color.Black), e.X - pen.Width / 2, e.Y - pen.Width / 2, pen.Width, pen.Width);
                    layers.MouseCanvas.Image = tempBmp;
                }
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

                layers.MouseCanvas.MouseDown += new MouseEventHandler(Picture_MouseDown);
                layers.MouseCanvas.MouseMove += new MouseEventHandler(Picture_MouseMove);
                layers.MouseCanvas.MouseUp += new MouseEventHandler(Picture_MouseUp);

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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            activeKeys[Keys.Shift] = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            activeKeys[Keys.Shift] = false;
        }

        private void ChangeTool(NameTool name)
        {
            if (toolSettingValues.ContainsKey(name))
            {
                switch (name)
                {
                    case NameTool.Brush: tool = new BrushSetting(toolSettingValues[name]); break;
                    case NameTool.Eraser: tool = new EraserSetting(toolSettingValues[name]); break;
                    case NameTool.Fill: tool = new FillSetting(toolSettingValues[name]); break;
                    case NameTool.Line: tool = new LineSetting(toolSettingValues[name]); break;
                }
            }
            else
            {
                switch (name)
                {
                    case NameTool.Brush: tool = new BrushSetting(); break;
                    case NameTool.Eraser: tool = new EraserSetting(); break;
                    case NameTool.Fill: tool = new FillSetting(); break;
                    case NameTool.Line: tool = new LineSetting(); break;
                }
            }
        }

        private void ToolChange_Click(object sender, EventArgs e)
        {
            selectedTool.BackColor = Color.FromArgb(38, 38, 38);
            selectedTool = (Button)sender;
            selectedTool.BackColor = Color.FromArgb(25, 25, 25);

            if (toolSettingValues.ContainsKey(tool.Name))
                toolSettingValues[tool.Name] = tool.Settings;
            else
                toolSettingValues.Add(tool.Name, tool.Settings);

            switch (selectedTool.Name)
            {
                case "butBrush": ChangeTool(NameTool.Brush); break;
                case "butEraser": ChangeTool(NameTool.Eraser); break;
                case "butFill": ChangeTool(NameTool.Fill); break;
                case "butLine": ChangeTool(NameTool.Line); break;
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
