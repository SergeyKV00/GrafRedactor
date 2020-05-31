using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графический_редактор
{
    internal static class GraphicsExtension
    {
        public static List<T> SwapListItems<T>(this List<T> list, int first, int second)
        {
            T temp = list[first];
            list[first] = list[second];
            list[second] = temp;
            return list;
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static Bitmap FillPngBackground(this Bitmap bmp, int Width, int Height)
        {
            using (Graphics graph = Graphics.FromImage(bmp))
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
            }

            return bmp;
        }
        public static Bitmap FillPngBackground(this Bitmap bmp)
        {
            return bmp.FillPngBackground(bmp.Width, bmp.Height);
        }
        // Изменяет размер исходного изображения с сохранением пропорций
        public static Bitmap ImageZoom(Image sourceImage, float new_width, float new_height)
        {
            Bitmap updatedImage = new Bitmap((int)new_width, (int)new_height);

            float scale = Math.Min(new_width / sourceImage.Width, new_height / sourceImage.Height);
            int scaleWidth = (int)(sourceImage.Width * scale);
            int scaleHeight = (int)(sourceImage.Height * scale);

            using (Graphics graph = Graphics.FromImage(updatedImage))
            {

                graph.InterpolationMode = InterpolationMode.High;
                graph.CompositingQuality = CompositingQuality.HighQuality;
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                graph.DrawImage(sourceImage, new Rectangle(((int)new_width - scaleWidth) / 2, ((int)new_height - scaleHeight) / 2, scaleWidth, scaleHeight));
            }
            return updatedImage;
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

            graph.DrawImage(image, new Rectangle(((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight));
            return new Bitmap(scaleWidth, scaleHeight);
        }
        public static Bitmap Crop(this Image image, Rectangle selection)
        {
            Bitmap bmp = new Bitmap(image);
            Bitmap cropBmp = null;
            try
            {
                cropBmp = bmp.Clone(selection, bmp.PixelFormat);
                image.Dispose();
            }
            catch(OutOfMemoryException)
            {
                throw new Exception("Invalid Selection");
            }

            return cropBmp;
         
        }
        public static Bitmap CombineBitmap(ref List<Bitmap> images)
        {
            Bitmap finalImage = null;

            try
            {
                finalImage = new Bitmap(images[0].Width, images[0].Height);
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.Transparent);
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
