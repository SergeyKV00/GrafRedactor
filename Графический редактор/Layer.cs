using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Графический_редактор
{
    class LayerNode
    {
        public Bitmap Image { get; set; }
        public bool IsVisible { get; set; }
        public string Name { get; set; }

        public LayerNode(Bitmap image, bool flag, string name)
        {
            Image = image;
            IsVisible = flag;
            Name = name;
        }
    }

    class Layer : Canvas
    {
        private List<LayerNode> bitmaps;

        private ImageList images;
        private Bitmap comboBitTop, comboBitBottom;
        private int count, nameCount;

        public ListView View { get; set; }
        public int Count { get => count; }
        public int Number { get; set; }
        public bool Visible {
            get => bitmaps[Number].IsVisible;
            set
            {
                Match match = Regex.Match(bitmaps[Number].Name, @"\d+");
                bitmaps[Number].IsVisible = value;
                if (value)
                {
                    bitmaps[Number].Name = "Слой: " + match.Value;
                }
                else
                    bitmaps[Number].Name = "Скрытый слой: " + match.Value;
            }
        }
        public Layer(ref ListView listView, Size panel_size, Size image_size)
            : base(panel_size, image_size)
        {
            View = listView;
            Clear();
        }

        public List<Bitmap> GetBitmap()
        {
            var tempList = new List<Bitmap>();
            foreach (LayerNode it in bitmaps)
                tempList.Add(it.Image);
            return tempList;
        }

        public Bitmap this[int index]
        {
            get
            {
                if (index >= Count && index < 0) throw new Exception("Out of range");
                return bitmaps[index].Image;
            }

            set
            {
                if (index >= Count && index < 0) throw new Exception("Out of range");
                bitmaps[index].Image = value;
            }
        }

        public void Add()
        {
            LayerNode tempNode = new LayerNode(new Bitmap(Width, Height), true, "Слой: " + nameCount);

            bitmaps.Insert(0, tempNode);
            nameCount++;
            count++;
            ViewUpdata();
            Number = 0;
        }

        public void RemoveAt(int index) // <!--- Check Index --->
        {
            bitmaps.RemoveAt(index);
            count--;
            if (Count == 0) nameCount = 0;
            Number = 0;   
            Change();
            Update();
            ViewUpdata();          
        }

        public void Up()
        {
            if (Number == 0 || Count < 2) return;

            bitmaps.Swap(Number, Number - 1);
            Number--;
            Change();
            ViewUpdata();
        }

        public void Down()
        {
            if (Number == Count - 1 || Count < 2) return;
            bitmaps.Swap(Number, Number + 1);
            Number++;
            Change();
            ViewUpdata();
        }

        public void Fill(Color color)
        {
            Graphics g = Graphics.FromImage(bitmaps[Number].Image);
            g.Clear(color);
            ViewUpdata();
        }

        public void Update()
        {
            ClearCanvas();
            Top.Image = comboBitTop;
            if(Count != 0 && bitmaps[Number].IsVisible)
            Middle.Image = bitmaps[Number].Image;
            Bottom.Image = comboBitBottom;
        }

        public void Clear()
        {
            bitmaps = new List<LayerNode>();
            images = new ImageList();
            images.ImageSize = new Size(35, 35);
            View.SmallImageList = images;
            count = 0;
            nameCount = 0;
            ClearCanvas();
        }

        public void Change()
        {
            ClearCanvas();
            comboBitBottom = new Bitmap(Width, Height);
            comboBitTop = new Bitmap(width, Height);

            if (Count > 0)
            {
                List<Bitmap> tempComboBitmaps = new List<Bitmap>();

                for (int i = Number + 1; i < Count; ++i)
                    if (bitmaps[i].IsVisible) tempComboBitmaps.Insert(0, bitmaps[i].Image);

                if (tempComboBitmaps.Count > 0)
                    comboBitBottom = GraphicsExtension.CombineBitmap(ref tempComboBitmaps);
                tempComboBitmaps.Clear();

                for (int i = 0; i < Number; ++i)
                    if (bitmaps[i].IsVisible) tempComboBitmaps.Insert(0, bitmaps[i].Image);

                if (tempComboBitmaps.Count > 0)
                    comboBitTop = GraphicsExtension.CombineBitmap(ref tempComboBitmaps);

                if (bitmaps[Number].IsVisible)
                    Middle.Image = bitmaps[Number].Image;
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
                tempBmp.Add(new Bitmap(bitmaps[Count - i - 1].Image));                       
                images.Images.Add(GraphicsExtension.CombineBitmap(ref tempBmp));

                ListViewItem tempItem = new ListViewItem(new string[] { "", bitmaps[Count - i - 1].Name });
                tempItem.ImageIndex = images.Images.Count - 1;
                View.Items.Insert(0, tempItem);
            }
            if(Count != 0)
            {
                View.Items[Number].Selected = true;
                View.Select();
            }
        }
    }
}
