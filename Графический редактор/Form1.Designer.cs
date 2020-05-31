namespace Графический_редактор
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CanvasSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.listLayers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelForLayers = new System.Windows.Forms.Panel();
            this.LayoutForLayers = new System.Windows.Forms.TableLayoutPanel();
            this.butLayerUp = new System.Windows.Forms.Button();
            this.butLayerDown = new System.Windows.Forms.Button();
            this.butHidenLayer = new System.Windows.Forms.Button();
            this.butDeleteLayer = new System.Windows.Forms.Button();
            this.butNewLayer = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.panelResizeX = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.butCancel = new System.Windows.Forms.Button();
            this.butReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panelResizeALL = new System.Windows.Forms.Panel();
            this.panelResizeY = new System.Windows.Forms.Panel();
            this.LayoutButtonWindow = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonWindowMode = new System.Windows.Forms.Button();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.panelX_Default = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.InsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panelForLayers.SuspendLayout();
            this.LayoutForLayers.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.LayoutTools.SuspendLayout();
            this.LayoutButtonWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenu,
            this.ImageToolStripMenu});
            this.menuStrip.Location = new System.Drawing.Point(5, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(120, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1270, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.menuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManForm_MouseUp);
            // 
            // FileToolStripMenu
            // 
            this.FileToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.InsertToolStripMenuItem,
            this.menuItemSaveFile});
            this.FileToolStripMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FileToolStripMenu.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.FileToolStripMenu.Name = "FileToolStripMenu";
            this.FileToolStripMenu.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenu.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CreateToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreatePictureToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // menuItemSaveFile
            // 
            this.menuItemSaveFile.Enabled = false;
            this.menuItemSaveFile.Name = "menuItemSaveFile";
            this.menuItemSaveFile.Size = new System.Drawing.Size(224, 26);
            this.menuItemSaveFile.Text = "Сохранить Как...";
            this.menuItemSaveFile.Click += new System.EventHandler(this.SaveFileMenu_Click);
            // 
            // ImageToolStripMenu
            // 
            this.ImageToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CanvasSizeToolStripMenuItem,
            this.ImageSizeToolStripMenuItem});
            this.ImageToolStripMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImageToolStripMenu.Name = "ImageToolStripMenu";
            this.ImageToolStripMenu.Size = new System.Drawing.Size(121, 24);
            this.ImageToolStripMenu.Text = "Изображение";
            // 
            // CanvasSizeToolStripMenuItem
            // 
            this.CanvasSizeToolStripMenuItem.Name = "CanvasSizeToolStripMenuItem";
            this.CanvasSizeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.CanvasSizeToolStripMenuItem.Text = "Размер холста";
            this.CanvasSizeToolStripMenuItem.Click += new System.EventHandler(this.SizePictureToolMenu_Click);
            // 
            // ImageSizeToolStripMenuItem
            // 
            this.ImageSizeToolStripMenuItem.Name = "ImageSizeToolStripMenuItem";
            this.ImageSizeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.ImageSizeToolStripMenuItem.Text = "Размер изображения";
            this.ImageSizeToolStripMenuItem.Click += new System.EventHandler(this.SizeImageToolMenu_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.listLayers);
            this.rightPanel.Controls.Add(this.panelForLayers);
            this.rightPanel.Controls.Add(this.labelNumber);
            this.rightPanel.Location = new System.Drawing.Point(990, 88);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(285, 628);
            this.rightPanel.TabIndex = 3;
            // 
            // listLayers
            // 
            this.listLayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listLayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listLayers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listLayers.ForeColor = System.Drawing.SystemColors.Info;
            this.listLayers.FullRowSelect = true;
            this.listLayers.Location = new System.Drawing.Point(0, 186);
            this.listLayers.Margin = new System.Windows.Forms.Padding(0);
            this.listLayers.MultiSelect = false;
            this.listLayers.Name = "listLayers";
            this.listLayers.Size = new System.Drawing.Size(283, 399);
            this.listLayers.TabIndex = 5;
            this.listLayers.UseCompatibleStateImageBehavior = false;
            this.listLayers.View = System.Windows.Forms.View.Details;
            this.listLayers.SelectedIndexChanged += new System.EventHandler(this.IndexChange);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 140;
            // 
            // panelForLayers
            // 
            this.panelForLayers.Controls.Add(this.LayoutForLayers);
            this.panelForLayers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelForLayers.Location = new System.Drawing.Point(0, 585);
            this.panelForLayers.Name = "panelForLayers";
            this.panelForLayers.Size = new System.Drawing.Size(283, 41);
            this.panelForLayers.TabIndex = 7;
            // 
            // LayoutForLayers
            // 
            this.LayoutForLayers.ColumnCount = 5;
            this.LayoutForLayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutForLayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutForLayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutForLayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutForLayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutForLayers.Controls.Add(this.butLayerUp, 1, 0);
            this.LayoutForLayers.Controls.Add(this.butLayerDown, 2, 0);
            this.LayoutForLayers.Controls.Add(this.butHidenLayer, 0, 0);
            this.LayoutForLayers.Controls.Add(this.butDeleteLayer, 3, 0);
            this.LayoutForLayers.Controls.Add(this.butNewLayer, 4, 0);
            this.LayoutForLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutForLayers.Location = new System.Drawing.Point(0, 0);
            this.LayoutForLayers.Name = "LayoutForLayers";
            this.LayoutForLayers.RowCount = 1;
            this.LayoutForLayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutForLayers.Size = new System.Drawing.Size(283, 41);
            this.LayoutForLayers.TabIndex = 4;
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
            this.butHidenLayer.Click += new System.EventHandler(this.ButLayerHiden_Click);
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
            this.panelTools.Controls.Add(this.butCancel);
            this.panelTools.Controls.Add(this.butReturn);
            this.panelTools.Controls.Add(this.label1);
            this.panelTools.Controls.Add(this.LayoutTools);
            this.panelTools.Location = new System.Drawing.Point(0, 28);
            this.panelTools.Margin = new System.Windows.Forms.Padding(0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1280, 60);
            this.panelTools.TabIndex = 4;
            this.panelTools.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panelTools.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManForm_MouseUp);
            // 
            // butCancel
            // 
            this.butCancel.BackgroundImage = global::Графический_редактор.Properties.Resources.ReturnOFF;
            this.butCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butCancel.Enabled = false;
            this.butCancel.FlatAppearance.BorderSize = 0;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Location = new System.Drawing.Point(123, 19);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(44, 27);
            this.butCancel.TabIndex = 1;
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butReturn
            // 
            this.butReturn.BackgroundImage = global::Графический_редактор.Properties.Resources.CancelOFF;
            this.butReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butReturn.Enabled = false;
            this.butReturn.FlatAppearance.BorderSize = 0;
            this.butReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReturn.Location = new System.Drawing.Point(173, 19);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(44, 27);
            this.butReturn.TabIndex = 0;
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(997, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.PanelForDraw.AutoScroll = true;
            this.PanelForDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelForDraw.Location = new System.Drawing.Point(5, 88);
            this.PanelForDraw.Margin = new System.Windows.Forms.Padding(0);
            this.PanelForDraw.Name = "PanelForDraw";
            this.PanelForDraw.Size = new System.Drawing.Size(983, 628);
            this.PanelForDraw.TabIndex = 4;
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
            // LayoutButtonWindow
            // 
            this.LayoutButtonWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutButtonWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.LayoutButtonWindow.ColumnCount = 3;
            this.LayoutButtonWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutButtonWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutButtonWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutButtonWindow.Controls.Add(this.buttonClose, 2, 0);
            this.LayoutButtonWindow.Controls.Add(this.buttonWindowMode, 1, 0);
            this.LayoutButtonWindow.Controls.Add(this.buttonMinimized, 0, 0);
            this.LayoutButtonWindow.Location = new System.Drawing.Point(1130, 0);
            this.LayoutButtonWindow.Name = "LayoutButtonWindow";
            this.LayoutButtonWindow.RowCount = 1;
            this.LayoutButtonWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutButtonWindow.Size = new System.Drawing.Size(145, 28);
            this.LayoutButtonWindow.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.BackgroundImage = global::Графический_редактор.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(96, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.buttonClose.Size = new System.Drawing.Size(49, 28);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButClouse_Click);
            // 
            // buttonWindowMode
            // 
            this.buttonWindowMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonWindowMode.BackgroundImage = global::Графический_редактор.Properties.Resources.Minimize;
            this.buttonWindowMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWindowMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWindowMode.FlatAppearance.BorderSize = 0;
            this.buttonWindowMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWindowMode.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWindowMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWindowMode.Location = new System.Drawing.Point(48, 0);
            this.buttonWindowMode.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWindowMode.Name = "buttonWindowMode";
            this.buttonWindowMode.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.buttonWindowMode.Size = new System.Drawing.Size(48, 28);
            this.buttonWindowMode.TabIndex = 5;
            this.buttonWindowMode.UseVisualStyleBackColor = false;
            this.buttonWindowMode.Click += new System.EventHandler(this.ButtonWindowMode_Click);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMinimized.BackgroundImage = global::Графический_редактор.Properties.Resources.Collapse;
            this.buttonMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinimized.FlatAppearance.BorderSize = 0;
            this.buttonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimized.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimized.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMinimized.Location = new System.Drawing.Point(0, 0);
            this.buttonMinimized.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.buttonMinimized.Size = new System.Drawing.Size(48, 28);
            this.buttonMinimized.TabIndex = 2;
            this.buttonMinimized.UseVisualStyleBackColor = false;
            this.buttonMinimized.Click += new System.EventHandler(this.ButMinimized_Click);
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
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Logo.Image = global::Графический_редактор.Properties.Resources.Logo2;
            this.Logo.Location = new System.Drawing.Point(5, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(109, 27);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // InsertToolStripMenuItem
            // 
            this.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem";
            this.InsertToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.InsertToolStripMenuItem.Text = "Вставить";
            this.InsertToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.LayoutButtonWindow);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panelResizeALL);
            this.Controls.Add(this.PanelForDraw);
            this.Controls.Add(this.panelResizeY);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelX_Default);
            this.Controls.Add(this.panelResizeX);
            this.Controls.Add(this.panelTools);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.panelForLayers.ResumeLayout(false);
            this.LayoutForLayers.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.LayoutTools.ResumeLayout(false);
            this.LayoutButtonWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel PanelForDraw;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.Button butDeleteLayer;
        private System.Windows.Forms.Button butNewLayer;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveFile;
        private System.Windows.Forms.Button butHidenLayer;
        private System.Windows.Forms.Panel panelResizeX;
        private System.Windows.Forms.Panel panelResizeALL;
        private System.Windows.Forms.Panel panelResizeY;
        private System.Windows.Forms.Button butEraser;
        private System.Windows.Forms.ListView listLayers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button butLayerUp;
        private System.Windows.Forms.Button butLayerDown;
        private System.Windows.Forms.Panel panelForLayers;
        private System.Windows.Forms.TableLayoutPanel LayoutForLayers;
        private System.Windows.Forms.TableLayoutPanel LayoutButtonWindow;
        private System.Windows.Forms.Button buttonWindowMode;
        private System.Windows.Forms.Panel panelX_Default;
        private System.Windows.Forms.TableLayoutPanel LayoutTools;
        private System.Windows.Forms.Button butBrush;
        private System.Windows.Forms.Button butFill;
        private System.Windows.Forms.Button butCrop;
        private System.Windows.Forms.ToolStripMenuItem ImageToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem CanvasSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImageSizeToolStripMenuItem;
        private System.Windows.Forms.Button butRectangle;
        private System.Windows.Forms.Button butPolygon;
        private System.Windows.Forms.Button butEllipse;
        private System.Windows.Forms.Button butLine;
        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ToolStripMenuItem InsertToolStripMenuItem;
    }
}

