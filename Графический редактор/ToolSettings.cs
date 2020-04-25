using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using CtrLibrary;

namespace Графический_редактор
{
    public enum NameTool { Brush, Eraser, Fill, Line, Rectangle, Ellipse, Polygon }
    class ToolSetting
    {
        protected static Dictionary<NameTool, Control[]> Settings;
        virtual public void InstallTools(ref Panel panel)
        {
            for (int i = panel.Controls.Count - 1; i > 0; i--)
                panel.Controls.RemoveAt(i);

            panel.Controls.AddRange(Settings[Name]);
        }

        static ToolSetting()
        {
            Settings = new Dictionary<NameTool, Control[]>
            {
                { NameTool.Brush, null },
                { NameTool.Eraser, null },
                { NameTool.Fill, null },
                { NameTool.Line, null },
                { NameTool.Rectangle, null },
                { NameTool.Ellipse, null },
                { NameTool.Polygon, null }
            };
        }
        public NameTool Name { get; protected set; }
        virtual public Pen GetPen() => new Pen(Color.FromArgb(0, 0, 0, 0));
    }
    class BrushSetting : ToolSetting
    {
        public Color Color => ((ColorChanger)Settings[Name][0]).FirstColor;
        public int Depth => ((Slider)Settings[Name][1]).Value;
        public int Transparence => ((Slider)Settings[Name][2]).Value * 255 / 100;        
        public override Pen GetPen() => new Pen(Color.FromArgb(Transparence, Color), Depth);
        public BrushSetting()
        {
            Name = NameTool.Brush;
            if (Settings[Name] == null)
            {
                var color = new ColorChanger(new Point(100, 2)); // control
                color.BackImage = Properties.Resources.transfer;

                var slider1 = new Slider(new Point(150, 0), new Size(200, 50), "Размер:", 1, 200); // control
                slider1.Format = SliderFormat.Pixel;
                slider1.BackColor = Color.FromArgb(38, 38, 38);
                slider1.Value = 5;

                var slider2 = new Slider(new Point(350, 0), new Size(200, 50), "Непрозрачность:", 1, 100); // control            
                slider2.Format = SliderFormat.Percent;
                slider2.BackColor = Color.FromArgb(38, 38, 38);
                slider2.Value = 100;
                Settings[Name] = new Control[] { color, slider1, slider2 };
            }
        }
    }
    class EraserSetting : ToolSetting
    {
        public int Depth => ((Slider)Settings[Name][0]).Value;
        public override Pen GetPen() => new Pen(Color.FromArgb(0, 0, 0, 0), Depth);

        public EraserSetting()
        {
            Name = NameTool.Eraser;
            if (Settings[Name] == null)
            {
                var slider1 = new Slider(new Point(100, 0), new Size(200, 50), "Размер:", 1, 200);
                slider1.Format = SliderFormat.Pixel;
                slider1.BackColor = Color.FromArgb(38, 38, 38);
                slider1.Value = 5;

                Settings[Name] = new Control[] { slider1 };
            }          
        }
    }
    class FillSetting : ToolSetting
    {
        public int Transparence => ((Slider)Settings[Name][1]).Value * 255 / 100;
        public Color Color => ((ColorChanger)Settings[Name][0]).FirstColor;
        public override Pen GetPen() => new Pen(Color.FromArgb(Transparence, Color));

        public FillSetting()
        {
            Name = NameTool.Fill;
            if(Settings[Name] == null)
            {
                var color = new ColorChanger(new Point(100, 2));
                color.BackImage = Properties.Resources.transfer;

                var slider = new Slider(new Point(150, 0), new Size(200, 50), "Непрозрачность:", 1, 100);
                slider.Format = SliderFormat.Percent;
                slider.BackColor = Color.FromArgb(38, 38, 38);
                slider.Value = 100;

                Settings[Name] = new Control[] { color, slider };
            }
        }
    }
    class LineSetting : ToolSetting
    {
        public Color Color => ((ColorSelection)Settings[Name][0]).Color;
        public int Depth => ((Slider)Settings[Name][1]).Value;
        public override Pen GetPen() => new Pen(Color, Depth);
        public LineSetting()
        {
            Name = NameTool.Line;
            if(Settings[Name] == null)
            {
                var color = new ColorSelection(new Point(100, 8), new Size(90, 36));
                color.LabelText = "Цвет: ";

                var slider = new Slider(new Point(190, 0), new Size(200, 50), "Размер:", 1, 50);
                slider.Format = SliderFormat.Pixel;
                slider.BackColor = Color.FromArgb(38, 38, 38);
                slider.Value = 1;

                Settings[Name] = new Control[] { color, slider };
            }
        }
    }
    class RectangleSetting : ToolSetting
    {   
        public int Depth => ((Slider)Settings[Name][0]).Value;
        public Color BorderColor => ((ColorSelection)Settings[Name][1]).Color;
        public Color FillColor => ((ColorSelection)Settings[Name][2]).Color;
        public override Pen GetPen() => new Pen(BorderColor, Depth);
        public RectangleSetting(NameTool name = NameTool.Rectangle)
        {
            Name = name;
            if(Settings[Name] == null)
            {
                var borderColor = new ColorSelection(new Point(100, 8), new Size(90, 36));
                borderColor.LabelText = "Рамка:";

                var fillColor = new ColorSelection(new Point(190, 8), new Size(110, 36));
                fillColor.LabelText = "Заливка:";

                var slider = new Slider(new Point(300, 0), new Size(200, 50), "Размер:", 0, 100);
                slider.Format = SliderFormat.Pixel;
                slider.BackColor = Color.FromArgb(38, 38, 38);
                slider.Value = 5;

                Settings[Name] = new Control[] { slider, borderColor, fillColor };
            }
        }       
    }
    class EllipseSetting : RectangleSetting
    {
        public EllipseSetting()
            : base(NameTool.Ellipse) { }
    }
    class PolygonSetting : RectangleSetting
    {
        public List<Point> Points { get; }
        public Bitmap Image { get; set; }

        public PolygonSetting()
            : base(NameTool.Polygon)
        {
            Points = new List<Point>();
        }

        public void AddPoint(Point point) => Points.Add(point);
        public void RemoveAtPoint(int index) => Points.RemoveAt(index);
    }
}
