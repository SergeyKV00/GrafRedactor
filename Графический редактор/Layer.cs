using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Графический_редактор
{
    class Layer : Canvas
    {
        private List<Bitmap> bitmaps;
        private List<bool> bitmapsVisible;
        private List<string> bitmapsName;

        private ImageList images;
        private Bitmap comboBitTop, comboBitBottom;
        private int count, nameCount;

        public ListView View { get; set; }
        public int Count { get => count; }
        public Layer(ref ListView listView, Size panel_size, Size image_size)
            : base(panel_size, image_size)
        {
            View = listView;
            bitmaps = new List<Bitmap>();
            bitmapsVisible = new List<bool>();
            bitmapsName = new List<string>();
            images = new ImageList();
            images.ImageSize = new Size(35, 35);
            View.SmallImageList = images;
            count = 0;
            nameCount = 0;
            ClearCanvas();
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

        public void Add()
        {
            bitmaps.Insert(0, new Bitmap(Width, Height));
            bitmapsVisible.Insert(0, true);
            bitmapsName.Insert(0, "Слой: " + nameCount);
            nameCount++;
            count++;
            ViewUpdata();
        }

        public void RemoveAt(int index) // <!--- Check Index --->
        {
            bitmaps.RemoveAt(index);
            bitmapsVisible.RemoveAt(index);
            bitmapsName.RemoveAt(index);
            count--;
            ViewUpdata();
        }

        public void Fill(int index, Color color)  // <!--- Check Index --->
        {
            Graphics g = Graphics.FromImage(bitmaps[index]);
            g.Clear(color);
            ViewUpdata();
        }

        public void Update(int index)
        {
            Top.Image = comboBitTop;
            Middle.Image = bitmaps[index];
            Bottom.Image = comboBitBottom;
        }

        public void Change(int index)  // <!--- Check Index --->
        {
            if (Count == 0) return; // !!!!!!
            ClearCanvas();
            if (Count == 1)
            {
                Middle.Image = bitmaps[0];
            }
            if (Count > 1)
            {
                List<Bitmap> tempComboBitmaps = new List<Bitmap>();

                for (int i = index + 1; i < Count; ++i)
                    if (bitmapsVisible[i]) tempComboBitmaps.Insert(0, bitmaps[i]);

                if (tempComboBitmaps.Count > 0)
                    comboBitBottom = GraphicsExtension.CombineBitmap(ref tempComboBitmaps);
                tempComboBitmaps.Clear();

                for (int i = 0; i < index; ++i)
                    if (bitmapsVisible[i]) tempComboBitmaps.Insert(0, bitmaps[i]);

                if (tempComboBitmaps.Count > 0)
                    comboBitTop = GraphicsExtension.CombineBitmap(ref tempComboBitmaps);

                if (bitmapsVisible[index])
                    Middle.Image = bitmaps[index];
                Top.Image = comboBitTop;
                Bottom.Image = comboBitBottom;
            }
        }

        public void ViewUpdata()
        {
            View.Items.Clear();
            for (int i = 0; i < Count; i++)
            {
                List<Bitmap> tempBmp = new List<Bitmap>();
                tempBmp.Add(new Bitmap(Picture.Image));
                tempBmp.Add(new Bitmap(bitmaps[Count - i - 1]));                       
                images.Images.Add(GraphicsExtension.CombineBitmap(ref tempBmp));

                ListViewItem tempItem = new ListViewItem(new string[] { "", bitmapsName[Count - i - 1] });
                tempItem.ImageIndex = images.Images.Count - 1;
                View.Items.Insert(0, tempItem);
            }
        }
    }
}
