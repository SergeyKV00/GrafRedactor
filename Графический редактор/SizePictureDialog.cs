using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графический_редактор
{  
    partial class SizePictureDialog : Form
    {
        public new Size Size { get; private set; } 
        public SizePictureDialog()
        {
            InitializeComponent();
            textBoxWidth.Text = "600";
            textBoxHeight.Text = "600";
            Size = new Size(0, 0);
            this.TopMost = true;
            this.ShowDialog();           
        }

        public SizePictureDialog(Size size)          
        {
            InitializeComponent();
            textBoxWidth.Text = size.Width.ToString();
            textBoxHeight.Text = size.Height.ToString();
            Size = new Size(0, 0);
            this.TopMost = true;
            this.ShowDialog();
           
        }

        private bool ValueCheck(object sender)
        {
            var temp = (TextBox)sender;
            if (!int.TryParse(temp.Text, out int value)) value = -1;

            if (value > 3000 || value < 1)
            {
                temp.ForeColor = Color.Red;
                return false;
            }
            temp.ForeColor = Color.Black;
            return true;
        }
        private void TextChange(object sender, EventArgs e)
        {
           if(ValueCheck(textBoxWidth) && ValueCheck(textBoxHeight))
           {
                label3.Visible = false;
                buttonOk.Enabled = true;
           }
           else
           {
                label3.Visible = true;
                buttonOk.Enabled = false;
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Size = new Size(Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text));
            Close();
        }
    }
}
