using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Графический_редактор
{

    public enum NameTool { Brush, Eraser, Fill }
    //public enum FormatBar { Depth, Transparence }
    class  Tool
    {
        protected List<Control[]> controls;
        virtual public void SetSettings(ref Panel panel)
        {
            if (controls == null) return;
            for (int i = panel.Controls.Count - 1; i > 1; i--)
                panel.Controls.RemoveAt(i);

            foreach (Control[] it in controls)
                panel.Controls.AddRange(it);
        }
        virtual public NameTool Name { get; }
    }

    class Brush : Tool
    {       
        public override NameTool Name { get => NameTool.Brush; }
        public int Depth => ((TrackBar)controls[0].GetValue(2)).Value;
        public int Transparence => ((TrackBar)controls[1].GetValue(2)).Value;
        public Color _Color => ((Button)controls[2].GetValue(0)).BackColor;
        public Pen GetPen() => new Pen(Color.FromArgb(Transparence, _Color), Depth);

        public Brush()
        {
            controls = new List<Control[]>
            {
                new TrackBarCustom(new Point(150, 11), "Размер:", 1, 100).Control,
                new TrackBarCustom(new Point(350, 11), "Непрозрачность:", 1, 255).Control,
                new ColorChangingPanel(new Point(120, -1)).Control
            };
        }
    }
    class Eraser : Tool
    {
        public override NameTool Name { get => NameTool.Eraser; }
        public int Depth => ((TrackBar)controls[0].GetValue(2)).Value;
        public Pen GetPen() => new Pen(Color.FromArgb(0, 0, 0, 0), Depth);

        public Eraser()
        {
            controls = new List<Control[]>();
            controls.Add(new TrackBarCustom(new Point(75, 11), "Размер:", 1, 100).Control);
        }
    }
    class PaintBasket : Tool
    {
        public override NameTool Name => NameTool.Fill;
        public int Transparence => ((TrackBar)controls[1].GetValue(2)).Value;
        public Color _Color => ((Button)controls[0].GetValue(0)).BackColor;
        public Pen GetPen() => new Pen(Color.FromArgb(Transparence, _Color));

        public PaintBasket()
        {
            controls = new List<Control[]>
            {
                new ColorChangingPanel(new Point(120, -1)).Control,
                new TrackBarCustom(new Point(150, 11), "Непрозрачность:", 1, 255).Control
            };
        }
    }

    #region ==== Tool Settings ====
    class ColorChangingPanel
    {
        private Button butColorFirst;
        private Button butColorSecond;
        private Button butColorChange;
        public Control[] Control => new Control[] { butColorFirst, butColorSecond, butColorChange };

        public ColorChangingPanel(Point local)
        {
            // butColorFirst
            butColorFirst = new Button();
            butColorFirst.BackColor = System.Drawing.Color.Black;
            butColorFirst.FlatAppearance.BorderColor = System.Drawing.Color.White;
            butColorFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butColorFirst.Location = new System.Drawing.Point(local.X - 30, local.Y + 6);
            butColorFirst.Name = "butColorFirst";
            butColorFirst.Size = new System.Drawing.Size(25, 25);
            butColorFirst.TabIndex = 11;
            butColorFirst.UseVisualStyleBackColor = false;
            butColorFirst.Click += new EventHandler(Color_Change);

            // butColorSecond
            butColorSecond = new Button();
            butColorSecond.BackColor = System.Drawing.Color.OrangeRed;
            butColorSecond.FlatAppearance.BorderColor = System.Drawing.Color.White;
            butColorSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butColorSecond.Location = new System.Drawing.Point(local.X - 14, local.Y + 20);
            butColorSecond.Name = "butColorSecond";
            butColorSecond.Size = new System.Drawing.Size(25, 25);
            butColorSecond.TabIndex = 12;
            butColorSecond.UseVisualStyleBackColor = false;
            butColorSecond.Click += new EventHandler(Color_Change);

            // buttColorChange
            butColorChange = new Button();
            butColorChange.BackgroundImage = global::Графический_редактор.Properties.Resources.transfer;
            butColorChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            butColorChange.FlatAppearance.BorderSize = 0;
            butColorChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butColorChange.Location = new System.Drawing.Point(local.X, local.Y);
            butColorChange.Name = "buttColorChange";
            butColorChange.Size = new System.Drawing.Size(30, 18);
            butColorChange.TabIndex = 13;
            butColorChange.UseVisualStyleBackColor = true;
            butColorChange.Click += new EventHandler(ColorPanel_Change);
        }

        private void Color_Change(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog.Color;
            }
        }
        private void ColorPanel_Change(object sender, EventArgs e)
        {
            Color color = butColorFirst.BackColor;
            butColorFirst.BackColor = butColorSecond.BackColor;
            butColorSecond.BackColor = color;
        }
    }
    class TrackBarCustom
    {
        private Label labelDepth;
        private TextBox textDepth;
        private TrackBar trackBarDepth;
        //private FormatBar Format { get; set; }
        public Control[] Control => new Control[] { labelDepth, textDepth, trackBarDepth };

        public TrackBarCustom(Point local, string labelText, int minimum, int maxinum)
        {
            // labelDepth
            labelDepth = new Label();
            labelDepth.AutoSize = true;
            labelDepth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            labelDepth.Location = new System.Drawing.Point(local.X, local.Y);
            labelDepth.Name = "labelDepth";
            labelDepth.Size = new System.Drawing.Size(61, 17);
            labelDepth.TabIndex = 12;
            labelDepth.Text = labelText;

            // textDepth
            textDepth = new TextBox();
            textDepth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            textDepth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textDepth.ForeColor = System.Drawing.SystemColors.Window;
            textDepth.Location = new System.Drawing.Point(local.X + 142, local.Y - 5);
            textDepth.Name = "textDepth";
            textDepth.Size = new System.Drawing.Size(50, 22);
            textDepth.TabIndex = 13;
            textDepth.Text = "10";
            textDepth.TextAlign = HorizontalAlignment.Right;

            // trackBarDepth
            trackBarDepth = new TrackBar();
            trackBarDepth.AutoSize = false;
            trackBarDepth.Location = new System.Drawing.Point(local.X, local.Y + 15);
            trackBarDepth.Maximum = maxinum;
            trackBarDepth.Minimum = minimum;
            trackBarDepth.Name = "trackBarDepth";
            trackBarDepth.Size = new System.Drawing.Size(192, 24);
            trackBarDepth.TabIndex = 6;
            trackBarDepth.TickStyle = System.Windows.Forms.TickStyle.None;
            trackBarDepth.Value = 10;
            trackBarDepth.Scroll += new EventHandler(TrackBar_Scroll);
        }

        private void TrackBar_Scroll(object sender, EventArgs e) => textDepth.Text = trackBarDepth.Value.ToString();
    }
    #endregion

}
