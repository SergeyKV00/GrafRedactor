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
        private Dictionary<Keys, bool> activeKeys;

        public Form1()
        {
            InitializeComponent();
            isCollapse = false;
            this.KeyPreview = true;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            resolution = Size;
            this.Size = Screen.PrimaryScreen.Bounds.Size;
        }
        #region Настройки формы

        private void Form1_Load(object sender, EventArgs e)
        {
            selectedTool = butBrush;
            tool = new BrushSetting();
            ToolChange_Click(selectedTool, null);

            activeKeys = new Dictionary<Keys, bool>
            {
                { Keys.Shift, false }
            };
        }
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
        private void ButLayerUp_Click(object sender, EventArgs e) => layers.Up();
        private void ButLayerDown_Click(object sender, EventArgs e) => layers.Down();
        private void ButClouse_Click(object sender, EventArgs e)
        {
            if (layers != null && layers.Count != 0)
            {
                switch (MessageBox.Show("Сохранить изменение?", "Paint++", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        if (SaveFile()) Close();
                        else return;
                        break;
                    case DialogResult.No:
                        Close();
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            Close();
        }
        private void Button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void Button3_Click(object sender, EventArgs e)
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

        #region Открытие и Сохранение файла, и Создание Холста
        private void InitLayers(Size pictureSize)
        {
            layers = new Layer(listView1, PanelForDraw.Size, pictureSize);

            PanelForDraw.Controls.Clear();
            PanelForDraw.Controls.Add(layers.Picture);

            layers.MouseCanvas.MouseDown += new MouseEventHandler(Picture_MouseDown);
            layers.MouseCanvas.MouseMove += new MouseEventHandler(Picture_MouseMove);
            layers.MouseCanvas.MouseUp += new MouseEventHandler(Picture_MouseUp);

            layers.Add();
        }
        private void CreatePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SizeDialog = new SizePictureDialog();
            if (new Size(0, 0) == SizeDialog.Size) return;

            InitLayers(SizeDialog.Size);

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
                InitLayers(new Bitmap(PanelForDraw.Width, PanelForDraw.Height).ImageZoom(image).Size);

                layers.Middle.Image = layers[0].ImageZoom(image);
                layers.Middle.Image = layers[0].ImageZoom(image);
                layers.Change();

                menuItemSaveFile.Enabled = true;
                butLayerUp.Enabled = true;
                butLayerDown.Enabled = true;
            }
        }
        private bool SaveFile()
        {
            if (layers == null) return false;
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
                return true;
            }
            return false;
        }
        #endregion

        #region Рисование
        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (layers.Count == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Отсуствуют слои", "Paint++", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            prevPoint.X = e.X;
            prevPoint.Y = e.Y;
            mouseClickPoint.X = e.X;
            mouseClickPoint.Y = e.Y;
            //layers.Change();

            pen = tool.GetPen();
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            if (tool.Name == NameTool.Fill && e.Button == MouseButtons.Left && layers.Visible)
            {
                layers.CurrentBitmap.FiilArea(pen, new Point(e.X, e.Y));
            }
            if (tool.Name == NameTool.Polygon && layers.Visible)
            {
                PolygonSetting tempPolygon = (PolygonSetting)tool;
                if (tempPolygon.Image == null) tempPolygon.Image = new Bitmap(layers.Width, layers.Height);

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

            if (e.Button == MouseButtons.Left && !layers.Visible)
                MessageBox.Show("Этот слой скрыт", "Paint++", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                pen = tool.GetPen();
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
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

        #region События слоев
        private void IndexChange(object sender, EventArgs e)
        {
            if (!(listView1.SelectedIndices.Count > 0)) return;
            int index = listView1.SelectedIndices[0];
            layers.Number = index;
            layers.Change();
        }
        private void MenuItemSaveFile_Click(object sender, EventArgs e) => SaveFile();

        private void SizePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SizeDialog = new SizePictureDialog();
            if (new Size(0, 0) == SizeDialog.Size) return;
        }

        private void ButNewLayer_Click(object sender, EventArgs e)
        {
            if (layers == null) return;
            layers.Add();
            menuItemSaveFile.Enabled = true;
        }
        private void ButDeleteLayer_Click(object sender, EventArgs e)
        {
            if (layers == null) return;
            layers.RemoveAt(layers.Number);
            if (layers.Count == 0) menuItemSaveFile.Enabled = false;
        }
        private void Button_HidenLayer(object sender, EventArgs e)
        {
            if (layers == null) return;
            if (layers.Count < 1) return;
            layers.Visible = !layers.Visible;
            layers.Change();
            layers.ViewUpdata();
        }
        #endregion

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            activeKeys[Keys.Shift] = true;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            activeKeys[Keys.Shift] = false;
        }
        private void ToolChange_Click(object sender, EventArgs e)
        {
            selectedTool.BackColor = Color.FromArgb(38, 38, 38);
            selectedTool = (Button)sender;
            selectedTool.BackColor = Color.FromArgb(25, 25, 25);

            switch (selectedTool.Name)
            {
                case "butBrush": tool = new BrushSetting(); break;
                case "butEraser": tool = new EraserSetting(); break;
                case "butFill": tool = new FillSetting(); break;
                case "butLine": tool = new LineSetting(); break;
                case "butRectangle": tool = new RectangleSetting(); break;
                case "butEllipse": tool = new EllipseSetting(); break;
                case "butPolygon": tool = new PolygonSetting(); break;
            }
            tool.InstallTools(panelTools);
            layers?.Update();
        }
    }
}
