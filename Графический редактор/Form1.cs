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

        // ==================== //
        #region Открытие и Сохранение файла, и Создание Холста
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
                List<Bitmap> temp = layers.GetLayerList();
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
        #endregion
        // ==================== //

        // ==================== //
        #region Рисование
        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (layers.Count == 0) return;
            prevPoint.X = e.X;
            prevPoint.Y = e.Y;
            mouseClickPoint.X = e.X;
            mouseClickPoint.Y = e.Y;
            //layers.Change();

            if (tool.Name == NameTool.Line) pen = tool.GetPen();
            if (tool.Name == NameTool.Rectangle) pen = tool.GetPen();
            if (tool.Name == NameTool.Fill && e.Button == MouseButtons.Left && layers.Visible)
            {
                pen = tool.GetPen();
                layers.CurrentBitmap.FiilArea(pen, new Point(e.X, e.Y));
            }
            if (tool.Name == NameTool.Polygon && layers.Visible)
            {
                PolygonSetting tempPolygon = (PolygonSetting)tool;
                if (tempPolygon.Image == null) tempPolygon.Image = new Bitmap(layers.Width, layers.Height);
                pen = tool.GetPen();

                if (e.Button == MouseButtons.Left)
                {
                    tempPolygon.AddPoint(new Point(e.X, e.Y));
                    if (tempPolygon.Points.Count > 1)
                    {
                        using (Graphics graph = Graphics.FromImage(tempPolygon.Image))
                        {
                            graph.DrawLines(new Pen(Color.Black), tempPolygon.Points.ToArray());
                        }
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if (tempPolygon.Points.Count > 1)
                    {
                        using (Graphics graph = Graphics.FromImage(layers.CurrentBitmap))
                        {
                            graph.FillPolygon(new SolidBrush(tempPolygon.FillColor), tempPolygon.Points.ToArray());
                            if (tempPolygon.Depth > 0)
                                graph.DrawPolygon(pen, tempPolygon.Points.ToArray());
                        }
                    }
                    tempPolygon.Points.Clear();
                    tempPolygon.Image = null;
                }
                tool = tempPolygon;
            }
        }
        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (layers.Count == 0) return;

            if (e.Button == MouseButtons.Left && layers.Visible)
            {
                switch (tool.Name)
                {
                    case NameTool.Line:
                        layers.CurrentBitmap.DrawLine(pen, mouseClickPoint, new Point(e.X, e.Y));
                        break;
                    case NameTool.Rectangle:
                        RectangleSetting tempRect = (RectangleSetting)tool;
                        layers.CurrentBitmap.DrawRectangle(tempRect.GetPen(), tempRect.FillColor, tempRect.Depth, mouseClickPoint, new Point(e.X, e.Y));
                        break;
                    case NameTool.Ellipse:
                        RectangleSetting tempElipse = (EllipseSetting)tool;
                        layers.CurrentBitmap.DrawEllipse(tempElipse.GetPen(), tempElipse.FillColor, tempElipse.Depth, mouseClickPoint, new Point(e.X, e.Y));
                        break;
                }
            }

            layers.Update();
            //layers.Change();
            layers.ViewUpdata();
            //layers.FastViewUpdata();
        }
        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            listView1.Select();
            if (layers.Count == 0) return;

            if (tool.Name == NameTool.Brush) pen = tool.GetPen();
            if (tool.Name == NameTool.Eraser) pen = tool.GetPen();

            if (pen != null)
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
            }

            if (e.Button == MouseButtons.Left && layers.Visible)
            {
                switch (tool.Name)
                {
                    case NameTool.Brush:
                        using (Graphics graph = Graphics.FromImage(layers.CurrentBitmap))
                            graph.DrawLine(pen, prevPoint.X, prevPoint.Y, e.X, e.Y);
                        layers.Update();
                        break;
                    case NameTool.Eraser:
                        using (Graphics graph = Graphics.FromImage(layers.CurrentBitmap))
                        {
                            graph.CompositingMode = CompositingMode.SourceCopy;
                            graph.DrawLine(pen, prevPoint.X, prevPoint.Y, e.X, e.Y);
                        }
                        layers.Update();
                        break;
                    case NameTool.Line:
                        Bitmap tempLine = new Bitmap(layers.Width, layers.Height);
                        layers.MouseCanvas.Image = tempLine.DrawLine(new Pen(Color.Black), mouseClickPoint, new Point(e.X, e.Y));
                        break;
                    case NameTool.Rectangle:
                        Bitmap tempRect = new Bitmap(layers.Width, layers.Height);
                        layers.MouseCanvas.Image = tempRect.DrawRectangle(new Pen(Color.Black), Color.FromArgb(0, 0, 0, 0), 1, mouseClickPoint, new Point(e.X, e.Y));
                        break;
                    case NameTool.Ellipse:
                        Bitmap tempEllipse = new Bitmap(layers.Width, layers.Height);
                        layers.MouseCanvas.Image = tempEllipse.DrawEllipse(new Pen(Color.Black), Color.FromArgb(0, 0, 0, 0), 1, mouseClickPoint, new Point(e.X, e.Y));
                        break;
                }
            }

            if (layers.Visible && tool.Name == NameTool.Polygon)
            {
                if (((PolygonSetting)tool).Points.Count > 0)
                {
                    Bitmap tempPolygon = new Bitmap(((PolygonSetting)tool).Image);
                    layers.MouseCanvas.Image = tempPolygon.DrawLine(new Pen(Color.Black), mouseClickPoint, new Point(e.X, e.Y));
                }
            }

            if (tool.Name == NameTool.Brush || tool.Name == NameTool.Eraser)
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
        #endregion
        // ==================== // 

        // ==================== //
        #region События слоев
        private void IndexChange(object sender, EventArgs e)
        {
            if (!(listView1.SelectedIndices.Count > 0)) return;
            int index = listView1.SelectedIndices[0];
            layers.Number = index;
            layers.Change();
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
        private void button_HidenLayer(object sender, EventArgs e)
        {
            if (layers == null) return;
            layers.Visible = !layers.Visible;
            layers.Change();
            layers.ViewUpdata();
        }
        #endregion
        // ==================== //

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
            object [] settings = null;
            if (toolSettingValues.ContainsKey(name))
                settings = toolSettingValues[name];

            switch (name)
            {
                case NameTool.Brush: tool = new BrushSetting(settings); break;
                case NameTool.Eraser: tool = new EraserSetting(settings); break;
                case NameTool.Fill: tool = new FillSetting(settings); break;
                case NameTool.Line: tool = new LineSetting(settings); break;
                case NameTool.Rectangle: tool = new RectangleSetting(settings); break;
                case NameTool.Ellipse: tool = new EllipseSetting(settings); break;
                case NameTool.Polygon: tool = new PolygonSetting(settings); break;
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
                case "butRectangle": ChangeTool(NameTool.Rectangle); break;
                case "butEllipse": ChangeTool(NameTool.Ellipse); break;
                case "butPolygon": ChangeTool(NameTool.Polygon); break;
            }
            tool.SetSettings(ref panelTools);
            if (layers != null) layers.Update();
        }

    }
}
