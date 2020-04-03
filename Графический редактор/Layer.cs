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
        private List<bool> bitmapsVisible;

        private int count;
        private int startPos;
        public int Count { get => count; }
        public List<Bitmap> Bitmaps { get => bitmaps; }

        public bool tryVisible(int index) => bitmapsVisible[index];

        public Layer(ListBox listBox)
        {
            this.listBox = listBox;
            Clear();
        }

        public Layer(ListBox listBox, Bitmap bmp, bool createHidenLayer)
        {
            this.listBox = listBox;
            Clear();

            if (createHidenLayer)
            {
                startPos = 1;
                bitmaps.Insert(0, bmp);
                bitmapsVisible.Insert(0, true);
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
                return bitmaps[index]; 
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
            bitmapsVisible.Insert(0, true);
            count++;

            listBox.Items.Insert(0, "Cлой: " + (count - startPos));
        }

        public void RemoveAt(int index)
        {
            bitmaps.RemoveAt(index);
            bitmapsVisible.RemoveAt(index);
            count--;

            listBox.Items.Clear();
            for(int i = 0; i < Count - startPos; i++)
            {
                if (bitmapsVisible[i])
                    listBox.Items.Add("Cлой: " + (Count - (i + startPos)));
                else
                    listBox.Items.Add("Скрытый Cлой: " + (Count - (i + startPos)));

            }
        }

        public void Visible(int index)
        {
            bitmapsVisible[index] = !bitmapsVisible[index];
            if(!bitmapsVisible[index])
                listBox.Items[index] = "Скрытый слой: " + (Count - index - startPos);
            else
                listBox.Items[index] = "Cлой: " + (Count - index - startPos);
        }

        public void Clear()
        {
            bitmaps = new List<Bitmap>();
            bitmapsVisible = new List<bool>();
            listBox.Items.Clear();
            count = 0;
            startPos = 0;
        }
        public void Redrawing(ref Canvas canvas)
        {
            int index = listBox.SelectedIndex;
            if (bitmaps.Count < 1) return;
            index = (index == -1) ? 0 : index;

            List<Bitmap> tempBitmaps = new List<Bitmap>();
            for (int i = index + 1; i < bitmaps.Count ; ++i)
                if(bitmapsVisible[i]) tempBitmaps.Insert(0, bitmaps[i]);


            if (tempBitmaps.Count > 0)
                canvas.ButtomPic.Image = GraphicsExtension.CombineBitmap(ref tempBitmaps);

            tempBitmaps.Clear();
            for (int i = 0; i < index; ++i)
                if (bitmapsVisible[i]) tempBitmaps.Insert(0, bitmaps[i]);

            if (tempBitmaps.Count > 0)
                canvas.TopPic.Image = GraphicsExtension.CombineBitmap(ref tempBitmaps);

            if(bitmapsVisible[index])
                canvas.CurrentPic.Image = bitmaps[index];
        }
    }
}
