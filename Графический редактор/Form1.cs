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
using System.Text.RegularExpressions;

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
        private void SizerMouseUp(object sender, MouseEventArgs e) => moveResize = false;
        private void butLayerUp_Click(object sender, EventArgs e) => layers.Up();
        private void butLayerDown_Click(object sender, EventArgs e) => layers.Down();
        private void button1_Click(object sender, EventArgs e) => Close();
        private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void trackBarEraser_Scroll(object sender, EventArgs e) => labelEraser.Text = trackBarEraser.Value.ToString();
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

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
        }
        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
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
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
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

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.bmp, *.jpg, *.png) | *.bmp; *.jpg; *.png";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
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

            Color tempColor = Color.FromArgb(25, 25, 25);
            switch (selectedTool.Name)
            {
                case "butBrush":
                    selectedTool.BackColor = tempColor;
                    tool = new Brush();
                    tool.SetSettings(ref panelTools);
                    break;
                case "butEraser":
                    selectedTool.BackColor = tempColor;
                    tool = new Eraser();
                    tool.SetSettings(ref panelTools);
                    break;
            }
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
           if(layers.Count == 0) menuItemSaveFile.Enabled = false;
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
