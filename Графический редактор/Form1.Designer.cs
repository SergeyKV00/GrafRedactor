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
            this.butHidenLayer = new System.Windows.Forms.Button();
            this.butDeleteLayer = new System.Windows.Forms.Button();
            this.butNewLayer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelResizeX = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelForDraw = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelResizeALL = new System.Windows.Forms.Panel();
            this.panelResizeY = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.butHidenLayer);
            this.panel2.Controls.Add(this.butDeleteLayer);
            this.panel2.Controls.Add(this.butNewLayer);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(990, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 628);
            this.panel2.TabIndex = 3;
            // 
            // butHidenLayer
            // 
            this.butHidenLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butHidenLayer.Location = new System.Drawing.Point(0, 313);
            this.butHidenLayer.Name = "butHidenLayer";
            this.butHidenLayer.Size = new System.Drawing.Size(283, 23);
            this.butHidenLayer.TabIndex = 3;
            this.butHidenLayer.Text = "Скрыть слой";
            this.butHidenLayer.UseVisualStyleBackColor = true;
            this.butHidenLayer.Click += new System.EventHandler(this.button_HidenLayer);
            // 
            // butDeleteLayer
            // 
            this.butDeleteLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butDeleteLayer.Location = new System.Drawing.Point(0, 336);
            this.butDeleteLayer.Name = "butDeleteLayer";
            this.butDeleteLayer.Size = new System.Drawing.Size(283, 23);
            this.butDeleteLayer.TabIndex = 2;
            this.butDeleteLayer.Text = "Удалить слой";
            this.butDeleteLayer.UseVisualStyleBackColor = true;
            this.butDeleteLayer.Click += new System.EventHandler(this.butDeleteLayer_Click);
            // 
            // butNewLayer
            // 
            this.butNewLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butNewLayer.Location = new System.Drawing.Point(0, 359);
            this.butNewLayer.Name = "butNewLayer";
            this.butNewLayer.Size = new System.Drawing.Size(283, 23);
            this.butNewLayer.TabIndex = 1;
            this.butNewLayer.Text = "Новый слой";
            this.butNewLayer.UseVisualStyleBackColor = true;
            this.butNewLayer.Click += new System.EventHandler(this.butNewLayer_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 382);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 244);
            this.listBox1.TabIndex = 0;
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
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 60);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBox1;
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
    }
}

