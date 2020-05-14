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
        public PictureBox Top { get; set; } // Верхние слои // Save
        public PictureBox Middle { get; set; } // Выбранный слой // Save
        public PictureBox Bottom { get; set; } // Нижние слои // Save
        public PictureBox MouseCanvas { get; private protected set; } // Для работы с мышью (Самый вверхний) // Save
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
        } // Save
        public Size PanelSize { get; set; } // Save

        protected Canvas(Size panel_size, Size image_size)
        {
            PanelSize = panel_size;
            Bottom = Create(image_size);
            Middle = Create(image_size);
            Top = Create(image_size);
            MouseCanvas = Create(image_size);
            MouseCanvas.Cursor = Cursors.Cross;

            Bottom.Location = new Point((panel_size.Width - Width) / 2, (panel_size.Height - Height) / 2);

            Bottom.Controls.Add(Middle);
            Middle.Controls.Add(Top);
            Top.Controls.Add(MouseCanvas);
        }
        private PictureBox Create(Size image_size)
        {
            Bitmap temp = new Bitmap(PanelSize.Width, PanelSize.Height);
            if (image_size.Width > PanelSize.Width && image_size.Height > PanelSize.Height)
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
        protected void Clear()
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
            Clear();
        }
    }
}
