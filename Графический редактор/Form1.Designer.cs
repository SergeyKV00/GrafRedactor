namespace Графический_редактор
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.butHidenLayer = new System.Windows.Forms.Button();
            this.butDeleteLayer = new System.Windows.Forms.Button();
            this.butNewLayer = new System.Windows.Forms.Button();
            this.panelResizeX = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butEraser = new System.Windows.Forms.Button();
            this.labelWidthPen = new System.Windows.Forms.Label();
            this.barWidthPen = new System.Windows.Forms.TrackBar();
            this.butColor1 = new System.Windows.Forms.Panel();
            this.butColor2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelForDraw = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelResizeALL = new System.Windows.Forms.Panel();
            this.panelResizeY = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWidthPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.menuItemSaveFile});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.файлToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.создатьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.CreatePictureToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // menuItemSaveFile
            // 
            this.menuItemSaveFile.Enabled = false;
            this.menuItemSaveFile.Name = "menuItemSaveFile";
            this.menuItemSaveFile.Size = new System.Drawing.Size(195, 26);
            this.menuItemSaveFile.Text = "Сохранить Как...";
            this.menuItemSaveFile.Click += new System.EventHandler(this.SaveFile);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1255, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1199, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.butHidenLayer);
            this.panel2.Controls.Add(this.butDeleteLayer);
            this.panel2.Controls.Add(this.butNewLayer);
            this.panel2.Location = new System.Drawing.Point(990, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 628);
            this.panel2.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.ForeColor = System.Drawing.SystemColors.Info;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 288);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(283, 338);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 150;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(283, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Изменение цвета";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ColorAction_Click);
            // 
            // butHidenLayer
            // 
            this.butHidenLayer.Location = new System.Drawing.Point(-1, 217);
            this.butHidenLayer.Name = "butHidenLayer";
            this.butHidenLayer.Size = new System.Drawing.Size(283, 23);
            this.butHidenLayer.TabIndex = 3;
            this.butHidenLayer.Text = "Скрыть слой";
            this.butHidenLayer.UseVisualStyleBackColor = true;
            this.butHidenLayer.Click += new System.EventHandler(this.button_HidenLayer);
            // 
            // butDeleteLayer
            // 
            this.butDeleteLayer.Location = new System.Drawing.Point(-1, 240);
            this.butDeleteLayer.Name = "butDeleteLayer";
            this.butDeleteLayer.Size = new System.Drawing.Size(283, 23);
            this.butDeleteLayer.TabIndex = 2;
            this.butDeleteLayer.Text = "Удалить слой";
            this.butDeleteLayer.UseVisualStyleBackColor = true;
            this.butDeleteLayer.Click += new System.EventHandler(this.butDeleteLayer_Click);
            // 
            // butNewLayer
            // 
            this.butNewLayer.Location = new System.Drawing.Point(-1, 263);
            this.butNewLayer.Name = "butNewLayer";
            this.butNewLayer.Size = new System.Drawing.Size(283, 23);
            this.butNewLayer.TabIndex = 1;
            this.butNewLayer.Text = "Новый слой";
            this.butNewLayer.UseVisualStyleBackColor = true;
            this.butNewLayer.Click += new System.EventHandler(this.butNewLayer_Click);
            // 
            // panelResizeX
            // 
            this.panelResizeX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResizeX.BackColor = System.Drawing.Color.Black;
            this.panelResizeX.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelResizeX.Location = new System.Drawing.Point(1275, 28);
            this.panelResizeX.Name = "panelResizeX";
            this.panelResizeX.Size = new System.Drawing.Size(11, 688);
            this.panelResizeX.TabIndex = 0;
            this.panelResizeX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.panelResizeX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.panelResizeX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.butEraser);
            this.panel1.Controls.Add(this.labelWidthPen);
            this.panel1.Controls.Add(this.barWidthPen);
            this.panel1.Controls.Add(this.butColor1);
            this.panel1.Controls.Add(this.butColor2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 60);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // butEraser
            // 
            this.butEraser.Enabled = false;
            this.butEraser.Location = new System.Drawing.Point(381, 13);
            this.butEraser.Name = "butEraser";
            this.butEraser.Size = new System.Drawing.Size(156, 25);
            this.butEraser.TabIndex = 8;
            this.butEraser.Text = "Резинка";
            this.butEraser.UseVisualStyleBackColor = true;
            this.butEraser.Visible = false;
            this.butEraser.Click += new System.EventHandler(this.butEraser_Click);
            // 
            // labelWidthPen
            // 
            this.labelWidthPen.AutoSize = true;
            this.labelWidthPen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWidthPen.Location = new System.Drawing.Point(282, 13);
            this.labelWidthPen.Name = "labelWidthPen";
            this.labelWidthPen.Size = new System.Drawing.Size(24, 17);
            this.labelWidthPen.TabIndex = 7;
            this.labelWidthPen.Text = "10";
            // 
            // barWidthPen
            // 
            this.barWidthPen.AutoSize = false;
            this.barWidthPen.Location = new System.Drawing.Point(118, 8);
            this.barWidthPen.Maximum = 100;
            this.barWidthPen.Minimum = 1;
            this.barWidthPen.Name = "barWidthPen";
            this.barWidthPen.Size = new System.Drawing.Size(170, 42);
            this.barWidthPen.TabIndex = 6;
            this.barWidthPen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barWidthPen.Value = 10;
            this.barWidthPen.Scroll += new System.EventHandler(this.barWidthPen_Scroll);
            // 
            // butColor1
            // 
            this.butColor1.BackColor = System.Drawing.Color.Black;
            this.butColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.butColor1.Location = new System.Drawing.Point(48, 8);
            this.butColor1.Name = "butColor1";
            this.butColor1.Size = new System.Drawing.Size(30, 30);
            this.butColor1.TabIndex = 4;
            this.butColor1.Click += new System.EventHandler(this.ColorAction_Click);
            // 
            // butColor2
            // 
            this.butColor2.BackColor = System.Drawing.Color.White;
            this.butColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.butColor2.Location = new System.Drawing.Point(60, 20);
            this.butColor2.Name = "butColor2";
            this.butColor2.Size = new System.Drawing.Size(30, 30);
            this.butColor2.TabIndex = 5;
            this.butColor2.Click += new System.EventHandler(this.ColorAction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Графический_редактор.Properties.Resources.transfer;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(84, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ColorChange_Click);
            // 
            // PanelForDraw
            // 
            this.PanelForDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelForDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelForDraw.Location = new System.Drawing.Point(0, 88);
            this.PanelForDraw.Margin = new System.Windows.Forms.Padding(0);
            this.PanelForDraw.Name = "PanelForDraw";
            this.PanelForDraw.Size = new System.Drawing.Size(988, 628);
            this.PanelForDraw.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1227, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "=";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelResizeALL
            // 
            this.panelResizeALL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResizeALL.BackColor = System.Drawing.Color.Black;
            this.panelResizeALL.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelResizeALL.Location = new System.Drawing.Point(1275, 715);
            this.panelResizeALL.Name = "panelResizeALL";
            this.panelResizeALL.Size = new System.Drawing.Size(5, 5);
            this.panelResizeALL.TabIndex = 1;
            this.panelResizeALL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.panelResizeALL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.panelResizeALL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // panelResizeY
            // 
            this.panelResizeY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResizeY.BackColor = System.Drawing.Color.Black;
            this.panelResizeY.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelResizeY.Location = new System.Drawing.Point(0, 715);
            this.panelResizeY.Name = "panelResizeY";
            this.panelResizeY.Size = new System.Drawing.Size(1275, 5);
            this.panelResizeY.TabIndex = 2;
            this.panelResizeY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.panelResizeY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.panelResizeY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelResizeALL);
            this.Controls.Add(this.PanelForDraw);
            this.Controls.Add(this.panelResizeY);
            this.Controls.Add(this.panelResizeX);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWidthPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelForDraw;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butDeleteLayer;
        private System.Windows.Forms.Button butNewLayer;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveFile;
        private System.Windows.Forms.Button butHidenLayer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelResizeX;
        private System.Windows.Forms.Panel panelResizeALL;
        private System.Windows.Forms.Panel panelResizeY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel butColor2;
        private System.Windows.Forms.Panel butColor1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar barWidthPen;
        private System.Windows.Forms.Label labelWidthPen;
        private System.Windows.Forms.Button butEraser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

