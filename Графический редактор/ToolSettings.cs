using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using CtrLibrary;

namespace Графический_редактор
{

    public enum NameTool { Brush, Eraser, Fill }
    class  Tool
    {
        protected List<Control> controls;
        virtual public void SetSettings(ref Panel panel)
        {
            if (controls == null) return;
            for (int i = panel.Controls.Count - 1; i > 0; i--)
                panel.Controls.RemoveAt(i);

            foreach (Control it in controls)
                panel.Controls.Add(it);
        }
        virtual public NameTool Name { get; }
    }

    class Brush : Tool
    {       
        public override NameTool Name { get => NameTool.Brush; }
        public int Depth => ((Slider)controls[1]).Value;
        public int Transparence => ((Slider)controls[2]).Value * 255 / 100;
        public Color _Color => ((ColorChanger)controls[0]).FirstColor;
        public Pen GetPen() => new Pen(Color.FromArgb(Transparence, _Color), Depth);

        public Brush()
        {
            var col = new ColorChanger(new Point(100, 2));
            col.BackImage = Properties.Resources.transfer;

            var slider1 = new Slider(new Point(150, 0), new Size(200, 50), "Размер:", 1, 200);            
            slider1.Format = SliderFormat.Pixel;
            slider1.BackColor = Color.FromArgb(38, 38, 38);
            slider1.Value = 5;

            var slider2 = new Slider(new Point(350, 0), new Size(200, 50), "Непрозрачность:", 1, 100);            
            slider2.Format = SliderFormat.Percent;
            slider2.BackColor = Color.FromArgb(38, 38, 38);
            slider2.Value = 100;

            controls = new List<Control> { col, slider1, slider2 };
        }
    }
    class Eraser : Tool
    {
        public override NameTool Name { get => NameTool.Eraser; }
        public int Depth => ((Slider)controls[0]).Value;
        public Pen GetPen() => new Pen(Color.FromArgb(0, 0, 0, 0), Depth);

        public Eraser()
        {
            controls = new List<Control>();
            var slider1 = new Slider(new Point(100, 0), new Size(200, 50), "Размер:", 1, 200);
            slider1.Format = SliderFormat.Pixel;
            slider1.BackColor = Color.FromArgb(38, 38, 38);
            slider1.Value = 5;

            controls.Add(slider1);
        }
    }
    class PaintBasket : Tool
    {
        public override NameTool Name => NameTool.Fill;
        public int Transparence => ((Slider)controls[1]).Value * 255 / 100;
        public Color _Color => ((ColorChanger)controls[0]).FirstColor;
        public Pen GetPen() => new Pen(Color.FromArgb(Transparence, _Color));

        public PaintBasket()
        {
            var col = new ColorChanger(new Point(100, 2));
            col.BackImage = Properties.Resources.transfer;

            var slider2 = new Slider(new Point(150, 0), new Size(200, 50), "Непрозрачность:", 1, 100);
            slider2.Format = SliderFormat.Percent;
            slider2.BackColor = Color.FromArgb(38, 38, 38);
            slider2.Value = 100;

            controls = new List<Control> { col , slider2 };
        }
    }
}
