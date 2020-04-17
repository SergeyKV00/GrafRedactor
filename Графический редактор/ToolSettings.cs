using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using CtrLibrary;

namespace Графический_редактор
{

    public enum NameTool { Brush, Eraser, Fill, Line, Rectangle, Ellipse, Polygon }
    class  ToolSetting
    {
        protected List<Control> controls;
        //protected static Dictionary<NameTool, object[]> Settings { get; }       
        virtual public void SetSettings(ref Panel panel)
        {
            if (controls == null) return;
            for (int i = panel.Controls.Count - 1; i > 0; i--)
                panel.Controls.RemoveAt(i);

            foreach (Control it in controls)
                panel.Controls.Add(it);
        }

        virtual public Pen GetPen() => new Pen(Color.FromArgb(0, 0, 0, 0));
        virtual public object[] Settings { get => controls.ToArray(); }
        virtual public NameTool Name { get; }
    }

    class BrushSetting : ToolSetting
    {
        public override NameTool Name { get => NameTool.Brush; }
        public int Depth => ((Slider)controls[1]).Value;
        public int Transparence => ((Slider)controls[2]).Value * 255 / 100;
        public Color Color => ((ColorChanger)controls[0]).FirstColor;
        public override Pen GetPen() => new Pen(Color.FromArgb(Transparence, Color), Depth);
        public override object[] Settings => new object[] { Depth, ((Slider)controls[2]).Value,
            ((ColorChanger)controls[0]).FirstColor, ((ColorChanger)controls[0]).SecondColor };

        public BrushSetting(object[] settings = null)
        {
            var color = new ColorChanger(new Point(100, 2));
            color.BackImage = Properties.Resources.transfer;

            var slider1 = new Slider(new Point(150, 0), new Size(200, 50), "Размер:", 1, 200);            
            slider1.Format = SliderFormat.Pixel;
            slider1.BackColor = Color.FromArgb(38, 38, 38);
            slider1.Value = 5;

            var slider2 = new Slider(new Point(350, 0), new Size(200, 50), "Непрозрачность:", 1, 100);            
            slider2.Format = SliderFormat.Percent;
            slider2.BackColor = Color.FromArgb(38, 38, 38);
            slider2.Value = 100;

            if(settings != null && settings.Length == 4)
            {
                slider1.Value = (int)settings[0];
                slider2.Value = (int)settings[1];
                color.FirstColor = (Color)settings[2];
                color.SecondColor = (Color)settings[3];
            }

            controls = new List<Control> { color, slider1, slider2 };
        }
    }
    class EraserSetting : ToolSetting
    {
        public override NameTool Name { get => NameTool.Eraser; }
        public int Depth => ((Slider)controls[0]).Value;
        public override Pen GetPen() => new Pen(Color.FromArgb(0, 0, 0, 0), Depth);
        public override object[] Settings => new object[] { Depth };

        public EraserSetting(object[] settings = null)
        {
            controls = new List<Control>();
            var slider1 = new Slider(new Point(100, 0), new Size(200, 50), "Размер:", 1, 200);
            slider1.Format = SliderFormat.Pixel;
            slider1.BackColor = Color.FromArgb(38, 38, 38);
            slider1.Value = 5;
            if(settings != null)
            {
                slider1.Value = (int)settings[0];
            }

            controls.Add(slider1);
        }
    }
    class FillSetting : ToolSetting
    {
        public override NameTool Name => NameTool.Fill;
        public int Transparence => ((Slider)controls[1]).Value * 255 / 100;
        public Color Color => ((ColorChanger)controls[0]).FirstColor;
        public override Pen GetPen() => new Pen(Color.FromArgb(Transparence, Color));
        public override object[] Settings => new object[] { ((Slider)controls[1]).Value, ((ColorChanger)controls[0]).FirstColor, ((ColorChanger)controls[0]).SecondColor };

        public FillSetting(object[] settings = null)
        {
            var color = new ColorChanger(new Point(100, 2));
            color.BackImage = Properties.Resources.transfer;

            var slider = new Slider(new Point(150, 0), new Size(200, 50), "Непрозрачность:", 1, 100);
            slider.Format = SliderFormat.Percent;
            slider.BackColor = Color.FromArgb(38, 38, 38);
            slider.Value = 100;

            if(settings != null)
            {
                slider.Value = (int)settings[0];
                color.FirstColor = (Color)settings[1];
                color.SecondColor = (Color)settings[2];               
            }

            controls = new List<Control> { color , slider };
        }
    }
    class LineSetting : ToolSetting
    {
        public override NameTool Name => NameTool.Line;
        public Color Color => ((ColorSelection)controls[0]).Color;
        public int Depth => ((Slider)controls[1]).Value;
        public override Pen GetPen() => new Pen(Color, Depth);
        public override object[] Settings => new object[] { Color, Depth };
        public LineSetting(object[] settings = null)
        {
            var color = new ColorSelection(new Point(100, 8), new Size(90, 36));
            color.LabelText = "Цвет: ";

            var slider = new Slider(new Point(190, 0), new Size(200, 50), "Размер:", 1, 50);
            slider.Format = SliderFormat.Pixel;
            slider.BackColor = Color.FromArgb(38, 38, 38);
            slider.Value = 1;

            if(settings != null)
            {
                color.Color = (Color)settings[0];
                slider.Value = (int)settings[1];
            }

            controls = new List<Control>() { color, slider };
        }
    }
    class RectangleSetting : ToolSetting
    {
        public override NameTool Name => NameTool.Rectangle;    
        public int Depth => ((Slider)controls[0]).Value;
        public Color BorderColor => ((ColorSelection)controls[1]).Color;
        public Color FillColor => ((ColorSelection)controls[2]).Color;
        public override Pen GetPen() => new Pen(BorderColor, Depth);
        public override object[] Settings => new object[] { Depth, BorderColor, FillColor };
        public RectangleSetting(object[] settings = null)
        {
            var borderColor = new ColorSelection(new Point(100, 8), new Size(90, 36));
            borderColor.LabelText = "Рамка:";

            var fillColor = new ColorSelection(new Point(190, 8), new Size(110, 36));
            fillColor.LabelText = "Заливка:";

            var slider = new Slider(new Point(300, 0), new Size(200, 50), "Размер:", 0, 100);
            slider.Format = SliderFormat.Pixel;
            slider.BackColor = Color.FromArgb(38, 38, 38);
            slider.Value = 5;

            if(settings != null)
            {
                slider.Value = (int)settings[0];
                borderColor.Color = (Color)settings[1];
                fillColor.Color = (Color)settings[2];
            }

            controls = new List<Control> { slider, borderColor, fillColor };
        }
        
    }
    class EllipseSetting : RectangleSetting
    {
        public override NameTool Name => NameTool.Ellipse;
        public EllipseSetting(object[] settings = null)
            : base(settings) { }
    }
    class PolygonSetting : RectangleSetting
    {
        public override NameTool Name => NameTool.Polygon;
        public List<Point> Points { get; }
        public Bitmap Image { get; set; }

        public PolygonSetting(object[] setting = null)
            : base(setting)
        {
            Points = new List<Point>();
        }

        public void AddPoint(Point point) => Points.Add(point);
        public void RemoveAtPoint(int index) => Points.RemoveAt(index);
    }
}
