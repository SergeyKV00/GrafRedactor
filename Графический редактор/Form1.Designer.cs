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
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерХолстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panelResizeX = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.LayoutTools = new System.Windows.Forms.TableLayoutPanel();
            this.butPolygon = new System.Windows.Forms.Button();
            this.butEllipse = new System.Windows.Forms.Button();
            this.butLine = new System.Windows.Forms.Button();
            this.butFill = new System.Windows.Forms.Button();
            this.butCrop = new System.Windows.Forms.Button();
            this.butEraser = new System.Windows.Forms.Button();
            this.butBrush = new System.Windows.Forms.Button();
            this.butRectangle = new System.Windows.Forms.Button();
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
            this.LayoutTools.SuspendLayout();
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
            this.файлToolStripMenuItem,
            this.изображениеToolStripMenuItem});
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.создатьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.CreatePictureToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // menuItemSaveFile
            // 
            this.menuItemSaveFile.Enabled = false;
            this.menuItemSaveFile.Name = "menuItemSaveFile";
            this.menuItemSaveFile.Size = new System.Drawing.Size(203, 26);
            this.menuItemSaveFile.Text = "Сохранить Как...";
            this.menuItemSaveFile.Click += new System.EventHandler(this.MenuItemSaveFile_Click);
            // 
            // изображениеToolStripMenuItem
            // 
            this.изображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерХолстаToolStripMenuItem,
            this.размерИзображенияToolStripMenuItem});
            this.изображениеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            this.изображениеToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.изображениеToolStripMenuItem.Text = "Изображение";
            // 
            // размерХолстаToolStripMenuItem
            // 
            this.размерХолстаToolStripMenuItem.Name = "размерХолстаToolStripMenuItem";
            this.размерХолстаToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.размерХолстаToolStripMenuItem.Text = "Размер холста";
            this.размерХолстаToolStripMenuItem.Click += new System.EventHandler(this.SizePictureToolStripMenuItem_Click);
            // 
            // размерИзображенияToolStripMenuItem
            // 
            this.размерИзображенияToolStripMenuItem.Name = "размерИзображенияToolStripMenuItem";
            this.размерИзображенияToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.размерИзображенияToolStripMenuItem.Text = "Размер изображения";
            this.размерИзображенияToolStripMenuItem.Click += new System.EventHandler(this.SizeImageToolStripMenuItem_Click);
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
            this.columnHeader2.Width = 140;
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
            this.butLayerUp.Click += new System.EventHandler(this.ButLayerUp_Click);
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
            this.butLayerDown.Click += new System.EventHandler(this.ButLayerDown_Click);
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
            this.butHidenLayer.Click += new System.EventHandler(this.Button_HidenLayer);
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
            this.butDeleteLayer.Click += new System.EventHandler(this.ButDeleteLayer_Click);
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
            this.butNewLayer.Click += new System.EventHandler(this.ButNewLayer_Click);
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
            this.panelTools.Controls.Add(this.LayoutTools);
            this.panelTools.Location = new System.Drawing.Point(0, 28);
            this.panelTools.Margin = new System.Windows.Forms.Padding(0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1280, 60);
            this.panelTools.TabIndex = 4;
            this.panelTools.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // LayoutTools
            // 
            this.LayoutTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LayoutTools.ColumnCount = 4;
            this.LayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutTools.Controls.Add(this.butPolygon, 3, 1);
            this.LayoutTools.Controls.Add(this.butEllipse, 3, 0);
            this.LayoutTools.Controls.Add(this.butLine, 2, 0);
            this.LayoutTools.Controls.Add(this.butFill, 0, 1);
            this.LayoutTools.Controls.Add(this.butCrop, 0, 1);
            this.LayoutTools.Controls.Add(this.butEraser, 1, 0);
            this.LayoutTools.Controls.Add(this.butBrush, 0, 0);
            this.LayoutTools.Controls.Add(this.butRectangle, 2, 1);
            this.LayoutTools.Location = new System.Drawing.Point(0, 0);
            this.LayoutTools.Name = "LayoutTools";
            this.LayoutTools.RowCount = 2;
            this.LayoutTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutTools.Size = new System.Drawing.Size(120, 60);
            this.LayoutTools.TabIndex = 0;
            // 
            // butPolygon
            // 
            this.butPolygon.BackgroundImage = global::Графический_редактор.Properties.Resources.polygon;
            this.butPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butPolygon.FlatAppearance.BorderSize = 0;
            this.butPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPolygon.Location = new System.Drawing.Point(93, 33);
            this.butPolygon.Name = "butPolygon";
            this.butPolygon.Size = new System.Drawing.Size(24, 23);
            this.butPolygon.TabIndex = 15;
            this.butPolygon.UseVisualStyleBackColor = true;
            this.butPolygon.Click += new System.EventHandler(this.ToolChange_Click);
            // 
            // butEllipse
            // 
            this.butEllipse.BackgroundImage = global::Графический_редактор.Properties.Resources.ellipse;
            this.butEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butEllipse.FlatAppearance.BorderSize = 0;
            this.butEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEllipse.Location = new System.Drawing.Point(93, 3);
            this.butEllipse.Name = "butEllipse";
            this.butEllipse.Size = new System.Drawing.Size(24, 23);
            this.butEllipse.TabIndex = 14;
            this.butEllipse.UseVisualStyleBackColor = true;
            this.butEllipse.Click += new System.EventHandler(this.ToolChange_Click);
            // 
            // butLine
            // 
            this.butLine.BackgroundImage = global::Графический_редактор.Properties.Resources.line;
            this.butLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butLine.FlatAppearance.BorderSize = 0;
            this.butLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLine.Location = new System.Drawing.Point(63, 3);
            this.butLine.Name = "butLine";
            this.butLine.Size = new System.Drawing.Size(24, 23);
            this.butLine.TabIndex = 13;
            this.butLine.UseVisualStyleBackColor = true;
            this.butLine.Click += new System.EventHandler(this.ToolChange_Click);
            // 
            // butFill
            // 
            this.butFill.BackgroundImage = global::Графический_редактор.Properties.Resources.paint_basket;
            this.butFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butFill.FlatAppearance.BorderSize = 0;
            this.butFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFill.Location = new System.Drawing.Point(3, 33);
            this.butFill.Name = "butFill";
            this.butFill.Size = new System.Drawing.Size(24, 24);
            this.butFill.TabIndex = 11;
            this.butFill.UseVisualStyleBackColor = true;
            this.butFill.Click += new System.EventHandler(this.ToolChange_Click);
            // 
            // butCrop
            // 
            this.butCrop.BackgroundImage = global::Графический_редактор.Properties.Resources.crop_tool;
            this.butCrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butCrop.FlatAppearance.BorderSize = 0;
            this.butCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCrop.Location = new System.Drawing.Point(33, 33);
            this.butCrop.Name = "butCrop";
            this.butCrop.Size = new System.Drawing.Size(24, 24);
            this.butCrop.TabIndex = 10;
            this.butCrop.UseVisualStyleBackColor = true;
            this.butCrop.Click += new System.EventHandler(this.ToolChange_Click);
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
            // butRectangle
            // 
            this.butRectangle.BackgroundImage = global::Графический_редактор.Properties.Resources.squareShape;
            this.butRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butRectangle.FlatAppearance.BorderSize = 0;
            this.butRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRectangle.Location = new System.Drawing.Point(63, 33);
            this.butRectangle.Name = "butRectangle";
            this.butRectangle.Size = new System.Drawing.Size(24, 23);
            this.butRectangle.TabIndex = 12;
            this.butRectangle.UseVisualStyleBackColor = true;
            this.butRectangle.Click += new System.EventHandler(this.ToolChange_Click);
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
            this.button1.Click += new System.EventHandler(this.ButClouse_Click);
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
            this.button3.Click += new System.EventHandler(this.Button3_Click);
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
            this.button2.Click += new System.EventHandler(this.Button2_Click);
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
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
            this.LayoutTools.ResumeLayout(false);
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
        private System.Windows.Forms.Button butEraser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button butLayerUp;
        private System.Windows.Forms.Button butLayerDown;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelX_Default;
        private System.Windows.Forms.TableLayoutPanel LayoutTools;
        private System.Windows.Forms.Button butBrush;
        private System.Windows.Forms.Button butFill;
        private System.Windows.Forms.Button butCrop;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерХолстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерИзображенияToolStripMenuItem;
        private System.Windows.Forms.Button butRectangle;
        private System.Windows.Forms.Button butPolygon;
        private System.Windows.Forms.Button butEllipse;
        private System.Windows.Forms.Button butLine;
    }
}

