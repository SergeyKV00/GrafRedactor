using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Графический_редактор
{
    abstract class Canvas
    {
        protected int width, height;
        public PictureBox Top { get; set; }
        public PictureBox Middle { get; set; }
        public PictureBox Bottom { get; set; }
        public PictureBox Picture { get; set; }
        public PictureBox MouseCanvas { get; }
        public int Width { get => width; }
        public int Height { get => height; } 

        protected Canvas(Size panel_size, Size image_size)
        {
            Picture = Create(panel_size, image_size);

            Bitmap ground = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(ground);
            g.FillPngBackground(Width, Height);
            Picture.Image = ground;

            Bottom = Create(panel_size, image_size);
            Middle = Create(panel_size, image_size);
            Top = Create(panel_size, image_size);
            MouseCanvas = Create(panel_size, image_size);
            MouseCanvas.Cursor = Cursors.Cross;

            Picture.Location = new Point((panel_size.Width - Width) / 2, (panel_size.Height - Height) / 2);

            Picture.Controls.Add(Bottom);
            Bottom.Controls.Add(Middle);
            Middle.Controls.Add(Top);
            Top.Controls.Add(MouseCanvas);
        }

        private PictureBox Create(Size panel_size, Size image_size)
        {
            Bitmap temp = new Bitmap(panel_size.Width, panel_size.Height);
            if (image_size.Width > panel_size.Width && image_size.Height > panel_size.Height)
                temp = temp.ImageZoom(new Bitmap(image_size.Width, image_size.Height));
            else
                temp = new Bitmap(image_size.Width, image_size.Height);
            PictureBox picture = new PictureBox();
            picture.BackColor = Color.FromArgb(0, 0, 0, 0);
            picture.Size = temp.Size;
            picture.Location = new Point(0, 0);
            width = temp.Width;
            height = temp.Height;

            return picture;
        }

        protected void ClearCanvas()
        {
            Bitmap tempBmp = new Bitmap(Width, Height);
            MouseCanvas.Image = tempBmp;
            Top.Image = tempBmp;
            Middle.Image = tempBmp;
            Bottom.Image = tempBmp;
        }
    }
}
