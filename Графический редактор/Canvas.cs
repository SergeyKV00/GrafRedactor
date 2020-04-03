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
    class Canvas
    {
        private PictureBox currentPic, topPic, buttomPic;
        public Size Size { get; set; }
        public PictureBox CurrentPic { get => currentPic; set => currentPic = value; }
        public PictureBox TopPic { get => topPic; set => topPic = value; }
        public PictureBox ButtomPic { get => buttomPic; set => buttomPic = value; }

        public Canvas(ref Panel panel, Size image_size)
        {
            CurrentPic = Create(panel.Size, image_size);
            topPic = Create(panel.Size, image_size);
            buttomPic = Create(panel.Size, image_size);

            buttomPic.Location = new Point((panel.Width - Size.Width) / 2, (panel.Height - Size.Height) / 2);
            CurrentPic.Location = new Point(0, 0);
            topPic.Location = new Point(0, 0);

            panel.Controls.Clear();
            panel.Controls.Add(buttomPic);
            buttomPic.Controls.Add(CurrentPic);
            CurrentPic.Controls.Add(topPic);
        }

        public PictureBox Create(Size panel_size, Size image_size)
        {
            Bitmap temp = new Bitmap(panel_size.Width, panel_size.Height);
            if (image_size.Width > panel_size.Width && image_size.Height > panel_size.Height)
                temp = temp.ImageZoom(new Bitmap(image_size.Width, image_size.Height));
            else
                temp = new Bitmap(image_size.Width, image_size.Height);
            PictureBox picture = new PictureBox();
            picture.BackColor = Color.FromArgb(0, 0, 0, 0);
            Size = picture.Size = temp.Size;

            return picture;
        }

        public void Clear()
        {
            var bmp = new Bitmap(Size.Width, Size.Height);
            CurrentPic.Image = bmp;
            TopPic.Image = bmp;
            ButtomPic.Image = bmp;     
        }

    }
}
