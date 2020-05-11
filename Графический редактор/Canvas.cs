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
        public PictureBox Top { get; set; } // Верхние слои
        public PictureBox Middle { get; set; } // Выбранный слой
        public PictureBox Bottom { get; set; } // Нижние слои
        public PictureBox MouseCanvas { get; } // Для работы с мышью (Самый вверхний)
        public int Width { get; private protected set; }
        public int Height { get; private protected set; }
        public Size Size
        {
            get => new Size(Width, Height);
            private protected set
            {
                Width = value.Width; 
                Height = value.Height;
            }
        }

        protected Canvas(Size panel_size, Size image_size)
        {
            Bottom = Create(panel_size, image_size);
            Middle = Create(panel_size, image_size);
            Top = Create(panel_size, image_size);
            MouseCanvas = Create(panel_size, image_size);
            MouseCanvas.Cursor = Cursors.Cross;

            Bottom.Location = new Point((panel_size.Width - Width) / 2, (panel_size.Height - Height) / 2);

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
            Size = temp.Size;

            return picture;
        }
        protected void ClearCanvas()
        {
            Bitmap emply = new Bitmap(Width, Height);
            MouseCanvas.Image = emply;
            Top.Image = emply;
            Middle.Image = emply;
            Bottom.Image = emply;
        }
        protected void Resize(Size new_size)
        {
            Size = new_size;

            MouseCanvas.Size = new_size;
            Top.Size = new_size;
            Middle.Size = new_size;
            Bottom.Size = new_size;
            ClearCanvas();
        }
    }
}
