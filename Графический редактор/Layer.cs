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
        private ListView listView;
        private ImageList imageList;
        private List<string> layersName;
        private List<Bitmap> bitmaps;
        private List<bool> bitmapsVisible;

        private int count;
        private int startPos;
        public int Count { get => count; }
        public List<Bitmap> Bitmaps { get => bitmaps; }

        public bool tryVisible(int index) => bitmapsVisible[index];

        public Layer(ListView listBox)
        {
            this.listView = listBox;
            Clear();
        }

        public Layer(ListView listBox, Bitmap bmp, bool createHidenLayer)
        {
            this.listView = listBox;
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
            LayerListUpData(0);

        }

        public void LayerListUpData(int index)
        {
            listView.Items.Clear();
            layersName.Clear();
            for(int i = 0; i < Count - startPos; i++)
            {
                if (bitmapsVisible[Count - i - 1 - startPos])
                    layersName.Insert(0, "Cлой: " + layersName.Count);
                else
                    layersName.Insert(0, "Скрытый слой " + layersName.Count);

                List<Bitmap> tempBmp = new List<Bitmap>();
                tempBmp.Add(new Bitmap(bitmaps[Count - 1]));
                tempBmp.Add(new Bitmap(bitmaps[Count - i - 1 - startPos]));
                imageList.Images.Add(GraphicsExtension.CombineBitmap(ref tempBmp));

                ListViewItem tempItem = new ListViewItem(new string[] { "", layersName[layersName.Count - i - startPos] });
                tempItem.ImageIndex = imageList.Images.Count - 1;
                listView.Items.Insert(0, tempItem);
            }

            if (Count < 2) return;
            listView.Items[index].Selected = true;
            listView.Select();
        }

        public void RemoveAt(int index)
        {
            bitmaps.RemoveAt(index);
            bitmapsVisible.RemoveAt(index);
            count--;
            LayerListUpData(0);
        }

        public void Visible(int index)
        {
            bitmapsVisible[index] = !bitmapsVisible[index];
        }

        public void Clear()
        {
            bitmaps = new List<Bitmap>();
            bitmapsVisible = new List<bool>();
            layersName = new List<string>();
            imageList = new ImageList();
            imageList.ImageSize = new Size(35, 35);
            listView.SmallImageList = imageList;
            listView.Items.Clear();
            count = 0;
            startPos = 0;
        }
        public void Redrawing(ref Canvas canvas)
        {
            int index;
            if (listView.SelectedIndices.Count == 0) index = -1;
            else index = listView.SelectedIndices[0];

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
