using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Графический_редактор
{
    static class GraphicsExtension
    {
        public static Graphics FillPngBackground(this Graphics graph, int Width, int Height)
        {
            graph.Clear(Color.White);
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(232, 232, 232));
            bool turn = false;
            for (int x = 0; x < Width; x += 10)
            {
                for (int y = (turn) ? 10 : 0; y < Height; y += 20)
                {
                    graph.FillRectangle(solidBrush, x, y, 10, 10);
                }
                turn = !turn;
            }

            return graph;
        }

        public static Bitmap ImageZoom(this Bitmap bmp, Bitmap image, float width, float height)
        {
            float scale = Math.Min(width / image.Width, height / image.Height);
            Graphics graph = Graphics.FromImage(bmp);

            graph.InterpolationMode = InterpolationMode.High;
            graph.CompositingQuality = CompositingQuality.HighQuality;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            var scaleWidth = (int)(image.Width * scale);
            var scaleHeight = (int)(image.Height * scale);

            graph.DrawImage(image, new Rectangle(((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight));
            return bmp;
        }

        public static Bitmap ImageZoom(this Bitmap bmp, Bitmap image)
        {
            float width = bmp.Width;
            float height = bmp.Height;
            float scale = Math.Min(width / image.Width, height / image.Height);
            Graphics graph = Graphics.FromImage(bmp);

            graph.InterpolationMode = InterpolationMode.High;
            graph.CompositingQuality = CompositingQuality.HighQuality;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            var scaleWidth = (int)(image.Width * scale);
            var scaleHeight = (int)(image.Height * scale);
            
            // Эту (тут ее уже нет ыыыыыыыыыы) ну она в этом месте
            graph.DrawImage(image, new Rectangle(((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight));
            return new Bitmap(scaleWidth, scaleHeight);
        }

        public static Bitmap CombineBitmap(ref List<Bitmap> images)
        {
            //read all images into memory
            Bitmap finalImage = null;

            try
            {
                // create a bitmap to hold the combined image
                finalImage = new Bitmap(images[0].Width, images[0].Height);

                // get a graphics object from the image so we can draw on it
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    // set background color
                    g.Clear(Color.Transparent);

                    // go through each image and draw it on the final image
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
                    }
                }

                return finalImage;
            }
            catch (Exception)
            {
                if (finalImage != null) finalImage.Dispose();
                throw;
            }
        }
    }
}
