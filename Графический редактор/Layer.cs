using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Графический_редактор
{
    class Layer
    {
        private ListBox listBox;
        private List<Bitmap> bitmaps;

        private int count;
        private int startPos;
        public int Count { get => count; }

        public Layer(ListBox listBox)
        {
            this.listBox = listBox;
            bitmaps = new List<Bitmap>();
            count = 0;
            startPos = 0;
        }

        public Layer(ListBox listBox, Bitmap bmp, bool createHidenLayer)
        {
            this.listBox = listBox;
            bitmaps = new List<Bitmap>();
            count = 0;
            startPos = 0;

            if (createHidenLayer)
            {
                startPos = 1;
                bitmaps.Insert(0, bmp); 
                count++;
                Graphics graph = Graphics.FromImage(bitmaps[0]);
                graph.FillPngBackground(bmp.Width, bmp.Height);
            }
        }

        public Bitmap this[int index]
        {
            get
            {
                if (index >= Count && index < 0) throw new Exception("Out of range");
                return bitmaps[index]; // ???
            }

            set
            {
                if (index >= Count && index < 0) throw new Exception("Out of range");
                bitmaps[index] = value;
            }
        }
        public void Add(Bitmap bmp)
        {
            bitmaps.Insert(0, bmp);
            count++;

            listBox.Items.Insert(0, "Cлой: " + (count - startPos));
        }
        public void SpreadLayersOnCanvas(ref Canvas canvas)
        {
            int index = listBox.SelectedIndex;
            if (index == -1 || bitmaps.Count < 2) return;

            List<Bitmap> tempBitmaps = new List<Bitmap>();
            for (int i = index + 1; i < bitmaps.Count ; ++i)
                tempBitmaps.Insert(0, bitmaps[i]);

            if (tempBitmaps.Count > 0)
                canvas.ButtomPic.Image = GraphicsExtension.CombineBitmap(ref tempBitmaps);

            tempBitmaps.Clear();
            for (int i = 0; i < index; ++i)
                tempBitmaps.Insert(0, bitmaps[i]);

            if (tempBitmaps.Count > 0)
                canvas.TopPic.Image = GraphicsExtension.CombineBitmap(ref tempBitmaps);

            /*List<Bitmap> tempBitmaps = new List<Bitmap>();
            for (int i = 0; i < index; i++)
                tempBitmaps.Add(bitmaps[i]);

            if (tempBitmaps.Count > 0)
                canvas.ButtomPic.Image = GraphicsExtension.CombineBitmap(ref tempBitmaps);

            tempBitmaps.Clear();
            for (int i = index + 1; i < bitmaps.Count; i++)
                tempBitmaps.Add(bitmaps[i]);

            if (tempBitmaps.Count > 0)
                canvas.TopPic.Image = GraphicsExtension.CombineBitmap(ref tempBitmaps);*/
        }
    }
}
