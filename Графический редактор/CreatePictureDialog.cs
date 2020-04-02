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
    public partial class CreatePictureDialog : Form
    {
        private Size pic_size;
        public Size picSize { get => pic_size; }

        public bool Cancel { get; set; }
        public CreatePictureDialog()
        {
            InitializeComponent();
            Cancel = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBoxHeight.Text != "" || textBoxWidth.Text != "")
            {
                int width = 0;
                int height = 0;

                if (!int.TryParse(textBoxWidth.Text, out width) || !int.TryParse(textBoxHeight.Text, out height))
                    return;
                Cancel = false;
                pic_size = new Size(width, height);
                Close();
            }
            
        }
    }
}
