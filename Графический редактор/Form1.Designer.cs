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
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butLayerUp = new System.Windows.Forms.Button();
            this.butLayerDown = new System.Windows.Forms.Button();
            this.butHidenLayer = new System.Windows.Forms.Button();
            this.butDeleteLayer = new System.Windows.Forms.Button();
            this.butNewLayer = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panelResizeX = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.butEraser = new System.Windows.Forms.Button();
            this.butBrush = new System.Windows.Forms.Button();
            this.labelEraser = new System.Windows.Forms.Label();
            this.trackBarEraser = new System.Windows.Forms.TrackBar();
            this.labelWidthPen = new System.Windows.Forms.Label();
            this.barWidthPen = new System.Windows.Forms.TrackBar();
            this.butColor1 = new System.Windows.Forms.Panel();
            this.butColor2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelForDraw = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelResizeALL = new System.Windows.Forms.Panel();
            this.panelResizeY = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelX_Default = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barWidthPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(120, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1270, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelNumber);
            this.panel2.Controls.Add(this.button4);
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
            this.listView1.Location = new System.Drawing.Point(0, 186);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(283, 399);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.IndexChange);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 41);
            this.panel3.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.butLayerUp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butLayerDown, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.butHidenLayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.butDeleteLayer, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.butNewLayer, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 41);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // butLayerUp
            // 
            this.butLayerUp.BackgroundImage = global::Графический_редактор.Properties.Resources.arrowUp;
            this.butLayerUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butLayerUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butLayerUp.Enabled = false;
            this.butLayerUp.FlatAppearance.BorderSize = 0;
            this.butLayerUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLayerUp.Location = new System.Drawing.Point(59, 3);
            this.butLayerUp.Name = "butLayerUp";
            this.butLayerUp.Size = new System.Drawing.Size(50, 35);
            this.butLayerUp.TabIndex = 7;
            this.butLayerUp.UseVisualStyleBackColor = true;
            this.butLayerUp.Click += new System.EventHandler(this.butLayerUp_Click);
            // 
            // butLayerDown
            // 
            this.butLayerDown.BackgroundImage = global::Графический_редактор.Properties.Resources.arrowDown;
            this.butLayerDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butLayerDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butLayerDown.Enabled = false;
            this.butLayerDown.FlatAppearance.BorderSize = 0;
            this.butLayerDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLayerDown.Location = new System.Drawing.Point(115, 3);
            this.butLayerDown.Name = "butLayerDown";
            this.butLayerDown.Size = new System.Drawing.Size(50, 35);
            this.butLayerDown.TabIndex = 8;
            this.butLayerDown.UseVisualStyleBackColor = true;
            this.butLayerDown.Click += new System.EventHandler(this.butLayerDown_Click);
            // 
            // butHidenLayer
            // 
            this.butHidenLayer.BackgroundImage = global::Графический_редактор.Properties.Resources.Eye;
            this.butHidenLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butHidenLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butHidenLayer.FlatAppearance.BorderSize = 0;
            this.butHidenLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHidenLayer.Location = new System.Drawing.Point(3, 3);
            this.butHidenLayer.Name = "butHidenLayer";
            this.butHidenLayer.Size = new System.Drawing.Size(50, 35);
            this.butHidenLayer.TabIndex = 3;
            this.butHidenLayer.UseVisualStyleBackColor = true;
            this.butHidenLayer.Click += new System.EventHandler(this.button_HidenLayer);
            // 
            // butDeleteLayer
            // 
            this.butDeleteLayer.BackgroundImage = global::Графический_редактор.Properties.Resources.basket;
            this.butDeleteLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butDeleteLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butDeleteLayer.FlatAppearance.BorderSize = 0;
            this.butDeleteLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDeleteLayer.Location = new System.Drawing.Point(171, 3);
            this.butDeleteLayer.Name = "butDeleteLayer";
            this.butDeleteLayer.Size = new System.Drawing.Size(50, 35);
            this.butDeleteLayer.TabIndex = 2;
            this.butDeleteLayer.UseVisualStyleBackColor = true;
            this.butDeleteLayer.Click += new System.EventHandler(this.butDeleteLayer_Click);
            // 
            // butNewLayer
            // 
            this.butNewLayer.BackgroundImage = global::Графический_редактор.Properties.Resources.layer;
            this.butNewLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butNewLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butNewLayer.FlatAppearance.BorderSize = 0;
            this.butNewLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNewLayer.Location = new System.Drawing.Point(227, 3);
            this.butNewLayer.Name = "butNewLayer";
            this.butNewLayer.Size = new System.Drawing.Size(53, 35);
            this.butNewLayer.TabIndex = 1;
            this.butNewLayer.UseVisualStyleBackColor = true;
            this.butNewLayer.Click += new System.EventHandler(this.butNewLayer_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumber.Location = new System.Drawing.Point(61, 119);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 17);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "NULL";
            this.labelNumber.Visible = false;
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
            // panelResizeX
            // 
            this.panelResizeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panelResizeX.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelResizeX.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelResizeX.Location = new System.Drawing.Point(1275, 0);
            this.panelResizeX.Name = "panelResizeX";
            this.panelResizeX.Size = new System.Drawing.Size(5, 720);
            this.panelResizeX.TabIndex = 0;
            this.panelResizeX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.panelResizeX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.panelResizeX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // panelTools
            // 
            this.panelTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTools.Controls.Add(this.tableLayoutPanel3);
            this.panelTools.Controls.Add(this.labelEraser);
            this.panelTools.Controls.Add(this.trackBarEraser);
            this.panelTools.Controls.Add(this.labelWidthPen);
            this.panelTools.Controls.Add(this.barWidthPen);
            this.panelTools.Controls.Add(this.butColor1);
            this.panelTools.Controls.Add(this.butColor2);
            this.panelTools.Controls.Add(this.pictureBox1);
            this.panelTools.Location = new System.Drawing.Point(0, 28);
            this.panelTools.Margin = new System.Windows.Forms.Padding(0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1280, 60);
            this.panelTools.TabIndex = 4;
            this.panelTools.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.butEraser, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.butBrush, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(60, 60);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // butEraser
            // 
            this.butEraser.BackgroundImage = global::Графический_редактор.Properties.Resources.sterka;
            this.butEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butEraser.FlatAppearance.BorderSize = 0;
            this.butEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEraser.Location = new System.Drawing.Point(33, 3);
            this.butEraser.Name = "butEraser";
            this.butEraser.Size = new System.Drawing.Size(24, 24);
            this.butEraser.TabIndex = 8;
            this.butEraser.UseVisualStyleBackColor = true;
            this.butEraser.Click += new System.EventHandler(this.ToolChange_Click);
            // 
            // butBrush
            // 
            this.butBrush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.butBrush.BackgroundImage = global::Графический_редактор.Properties.Resources.paintBrush;
            this.butBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butBrush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBrush.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butBrush.FlatAppearance.BorderSize = 0;
            this.butBrush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBrush.Location = new System.Drawing.Point(3, 3);
            this.butBrush.Name = "butBrush";
            this.butBrush.Size = new System.Drawing.Size(24, 24);
            this.butBrush.TabIndex = 9;
            this.butBrush.UseVisualStyleBackColor = false;
            this.butBrush.Click += new System.EventHandler(this.ToolChange_Click);
            // 
            // labelEraser
            // 
            this.labelEraser.AutoSize = true;
            this.labelEraser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEraser.Location = new System.Drawing.Point(1031, 13);
            this.labelEraser.Name = "labelEraser";
            this.labelEraser.Size = new System.Drawing.Size(24, 17);
            this.labelEraser.TabIndex = 10;
            this.labelEraser.Text = "10";
            // 
            // trackBarEraser
            // 
            this.trackBarEraser.AutoSize = false;
            this.trackBarEraser.Location = new System.Drawing.Point(855, 3);
            this.trackBarEraser.Maximum = 100;
            this.trackBarEraser.Minimum = 1;
            this.trackBarEraser.Name = "trackBarEraser";
            this.trackBarEraser.Size = new System.Drawing.Size(170, 42);
            this.trackBarEraser.TabIndex = 9;
            this.trackBarEraser.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarEraser.Value = 10;
            this.trackBarEraser.Scroll += new System.EventHandler(this.trackBarEraser_Scroll);
            // 
            // labelWidthPen
            // 
            this.labelWidthPen.AutoSize = true;
            this.labelWidthPen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWidthPen.Location = new System.Drawing.Point(801, 13);
            this.labelWidthPen.Name = "labelWidthPen";
            this.labelWidthPen.Size = new System.Drawing.Size(24, 17);
            this.labelWidthPen.TabIndex = 7;
            this.labelWidthPen.Text = "10";
            // 
            // barWidthPen
            // 
            this.barWidthPen.AutoSize = false;
            this.barWidthPen.Location = new System.Drawing.Point(625, 3);
            this.barWidthPen.Maximum = 100;
            this.barWidthPen.Minimum = 1;
            this.barWidthPen.Name = "barWidthPen";
            this.barWidthPen.Size = new System.Drawing.Size(170, 42);
            this.barWidthPen.TabIndex = 6;
            this.barWidthPen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barWidthPen.Value = 10;
            this.barWidthPen.Scroll += new System.EventHandler(this.trackBarWidthPen_Scroll);
            // 
            // butColor1
            // 
            this.butColor1.BackColor = System.Drawing.Color.Black;
            this.butColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.butColor1.Location = new System.Drawing.Point(1129, 8);
            this.butColor1.Name = "butColor1";
            this.butColor1.Size = new System.Drawing.Size(30, 30);
            this.butColor1.TabIndex = 4;
            this.butColor1.Click += new System.EventHandler(this.ColorAction_Click);
            // 
            // butColor2
            // 
            this.butColor2.BackColor = System.Drawing.Color.White;
            this.butColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.butColor2.Location = new System.Drawing.Point(1141, 20);
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
            this.pictureBox1.Location = new System.Drawing.Point(1165, 2);
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
            this.PanelForDraw.Location = new System.Drawing.Point(5, 88);
            this.PanelForDraw.Margin = new System.Windows.Forms.Padding(0);
            this.PanelForDraw.Name = "PanelForDraw";
            this.PanelForDraw.Size = new System.Drawing.Size(983, 628);
            this.PanelForDraw.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelResizeALL
            // 
            this.panelResizeALL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResizeALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
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
            this.panelResizeY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panelResizeY.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelResizeY.Location = new System.Drawing.Point(0, 715);
            this.panelResizeY.Name = "panelResizeY";
            this.panelResizeY.Size = new System.Drawing.Size(1275, 5);
            this.panelResizeY.TabIndex = 2;
            this.panelResizeY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.panelResizeY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.panelResizeY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1130, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(145, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::Графический_редактор.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(96, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(49, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImage = global::Графический_редактор.Properties.Resources.Minimize;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(48, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(48, 28);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImage = global::Графический_редактор.Properties.Resources.Collapse;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(48, 28);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelX_Default
            // 
            this.panelX_Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panelX_Default.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelX_Default.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelX_Default.Location = new System.Drawing.Point(0, 0);
            this.panelX_Default.Name = "panelX_Default";
            this.panelX_Default.Size = new System.Drawing.Size(5, 720);
            this.panelX_Default.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.pictureBox2.Image = global::Графический_редактор.Properties.Resources.Logo2;
            this.pictureBox2.Location = new System.Drawing.Point(5, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelResizeALL);
            this.Controls.Add(this.PanelForDraw);
            this.Controls.Add(this.panelResizeY);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelX_Default);
            this.Controls.Add(this.panelResizeX);
            this.Controls.Add(this.panelTools);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barWidthPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel PanelForDraw;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelEraser;
        private System.Windows.Forms.TrackBar trackBarEraser;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button butLayerUp;
        private System.Windows.Forms.Button butLayerDown;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelX_Default;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button butBrush;
    }
}

