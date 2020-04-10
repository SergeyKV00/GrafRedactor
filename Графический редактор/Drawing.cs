using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Графический_редактор
{
    static class Drawing
    {
        public static Bitmap DrawLine(this Bitmap bitmap, Pen pen, Point p1, Point p2)
        {
            using (Graphics graph = Graphics.FromImage(bitmap))
            {
                graph.DrawLine(pen, p1.X, p1.Y, p2.X, p2.Y);
            }
            return bitmap;
        }
        public static Bitmap DrawRectangle(this Bitmap bitmap, Pen pen, Color fillColor, int depth, Point p1, Point p2)
        {
            using (Graphics graph = Graphics.FromImage(bitmap))
            {
                int minX = Math.Min(p1.X, p2.X);
                int minY = Math.Min(p1.Y, p2.Y);
                int maxX = Math.Max(p1.X, p2.X);
                int maxY = Math.Max(p1.Y, p2.Y);

                graph.FillRectangle(new SolidBrush(fillColor), minX, minY, maxX - minX, maxY - minY);
                if (depth > 0)
                    graph.DrawRectangle(pen, minX, minY, maxX - minX, maxY - minY);
            }
            return bitmap;
        }
        public static Bitmap DrawEllipse(this Bitmap bitmap, Pen pen, Color fillColor, int depth, Point p1, Point p2)
        {
            using (Graphics graph = Graphics.FromImage(bitmap))
            {
                graph.FillEllipse(new SolidBrush(fillColor), p1.X - (p2.X - p1.X) / 2, p1.Y - (p2.Y - p1.Y) / 2, p2.X - p1.X, p2.Y - p1.Y);
                if (depth > 0)
                    graph.DrawEllipse(pen, p1.X - (p2.X - p1.X) / 2, p1.Y - (p2.Y - p1.Y) / 2, p2.X - p1.X, p2.Y - p1.Y);
            }
            return bitmap;
        }

        public static Bitmap FiilArea(this Bitmap bitmap, Pen pen, Point point)
        {
            if (point.X < 1 || point.X > bitmap.Width || point.Y < 1 || point.Y > bitmap.Height)
                return bitmap;

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            Color old_color, new_color;
            new_color = pen.Color;
            old_color = bitmap.GetPixel(point.X, point.Y);

            if (old_color == new_color)
                return bitmap;

            List<Point> points = new List<Point>();
            points.Add(new Point(point.X, point.Y));

            int Ntek = 0;

            do
            {
                if (points[Ntek].X + 1 < bitmap.Width)
                {
                    if (bitmap.GetPixel(points[Ntek].X + 1, points[Ntek].Y) == old_color)
                    {
                        points.Add(new Point(points[Ntek].X + 1, points[Ntek].Y));
                        bitmap.SetPixel(points[Ntek].X + 1, points[Ntek].Y, new_color);
                    }
                }
                if (points[Ntek].X - 1 >= 0)
                {
                    if (bitmap.GetPixel(points[Ntek].X - 1, points[Ntek].Y) == old_color)
                    {
                        points.Add(new Point(points[Ntek].X - 1, points[Ntek].Y));
                        bitmap.SetPixel(points[Ntek].X - 1, points[Ntek].Y, new_color);
                    }
                }
                if (points[Ntek].Y + 1 < bitmap.Height)
                {
                    if (bitmap.GetPixel(points[Ntek].X, points[Ntek].Y + 1) == old_color)
                    {
                        points.Add(new Point(points[Ntek].X, points[Ntek].Y + 1));
                        bitmap.SetPixel(points[Ntek].X, points[Ntek].Y + 1, new_color);
                    }
                }
                if (points[Ntek].Y - 1 >= 0)
                {
                    if (bitmap.GetPixel(points[Ntek].X, points[Ntek].Y - 1) == old_color)
                    {
                        points.Add(new Point(points[Ntek].X, points[Ntek].Y - 1));
                        bitmap.SetPixel(points[Ntek].X, points[Ntek].Y - 1, new_color);
                    }
                }
                Ntek++;
            } while (Ntek < points.Count - 1);

            return bitmap;
        }
    }
}

