using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Графический_редактор
{
    class Canvas : Form1
    {
        private PictureBox currentPic, topPic, buttomPic;
        public Size CanvasSize { get; set; }
        public PictureBox CurrentPic { get => currentPic; set => currentPic = value; }
        public PictureBox TopPic { get => topPic; set => topPic = value; }
        public PictureBox ButtomPic { get => buttomPic; set => buttomPic = value; }

        public Canvas(Size _size)
        {
            
        }

        public PictureBox Create(Size size)
        {
            Bitmap temp = new Bitmap(PanelForDraw.Width, PanelForDraw.Height);
            if (size.Width > PanelForDraw.Width && size.Height > PanelForDraw.Height)
                temp = temp.ImageZoom(new Bitmap(size.Width, size.Height));
            else
                temp = new Bitmap(size.Width, size.Height);
            var picture = new PictureBox();
            picture.BackColor = Color.FromArgb(0, 0, 0, 0);
            CanvasSize = picture.Size = temp.Size;
          /*picture.MouseMove += new MouseEventHandler(Picture_MouseMove);
            picture.MouseUp += new MouseEventHandler(Picture_MouseUp);*/

            bitmaps.Clear();
            listBox1.Items.Clear();
            bitmaps.Add(new Bitmap(picture.Width, picture.Height));
            listBox1.Items.Add("Cлой: " + bitmaps.Count);

            return picture;
        }
    }
}
