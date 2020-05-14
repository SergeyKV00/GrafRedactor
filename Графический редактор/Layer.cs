using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public LayerNode Clone()
        {
            return new LayerNode(new Bitmap(Image), IsVisible, Name);
        }
    }

    class Layer : Canvas
    {
        private Bitmap backGroundPNG; // Save
        private List<LayerNode> bitmaps; // Save
        private Bitmap comboBitTop, comboBitBottom;
        private int nameCount; // Save

        public delegate void LayerHandler(object sender);
        public event LayerHandler Change, NewLayer, RemoveLayer;

        public int Count { get; private set; } // Save
        public int Number { get; set; } // Save
        public ImageList ImageList { get; private set; } // Save
        public bool Visible
        {
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
        public Bitmap CurrentBitmap { get => bitmaps[Number].Image; set => bitmaps[Number].Image = value; }
        public Layer(Size panel_size, Size image_size)
            : base(panel_size, image_size)
        {
            backGroundPNG = new Bitmap(Width, Height).FillPngBackground();
            bitmaps = new List<LayerNode>();
            ImageList = new ImageList();
            ImageList.ImageSize = new Size(35, 35);
            Count = 0;
            nameCount = 0;
            Clear();            
        }
        public enum ResizeMode { Compression, Framing }     
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
        public List<Bitmap> GetLayerList()
        {
            var tempList = new List<Bitmap>();
            foreach (LayerNode it in bitmaps)
                tempList.Add(it.Image);
            return tempList;
        }
        public void Add()
        {
            Change?.Invoke(this);
            LayerNode tempNode = new LayerNode(new Bitmap(Width, Height), true, "Слой: " + nameCount);
            bitmaps.Insert(0, tempNode);
            nameCount++;
            Count++;
            Number = 0;

            NewLayer?.Invoke(this);
        }
        public void RemoveAt(int index)
        {
            try
            {
                Change?.Invoke(this);
                bitmaps.RemoveAt(index);
                Count--;
                if (Count == 0) nameCount = 0;
                Number = 0;
                Rebuilding();
                Update();

                RemoveLayer?.Invoke(this);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return;
            }

        }
        public void Up()
        {
            if (Number == 0 || Count < 2) return;
            bitmaps.SwapListItems(Number, Number - 1);
            Number--;
            Rebuilding();
            
        }
        public void Down()
        {
            if (Number == Count - 1 || Count < 2) return;
            bitmaps.SwapListItems(Number, Number + 1);
            Number++;
            Rebuilding();
            
        }
        public void Fill(Color color)
        {
            Graphics g = Graphics.FromImage(bitmaps[Number].Image);
            g.Clear(color);
            //Change?.Invoke(this);
        }
        public void Update()
        {
            Clear();
            Top.Image = comboBitTop;
            if (Count != 0 && bitmaps[Number].IsVisible)
                Middle.Image = bitmaps[Number].Image;
            Bottom.Image = comboBitBottom;
        }
        public void Rebuilding()
        {
            Clear();
            comboBitBottom = new Bitmap(Width, Height);
            comboBitTop = new Bitmap(Width, Height);

            if (Count > 0)
            {
                List<Bitmap> tempComboBitmaps = new List<Bitmap>();

                for (int i = Number + 1; i < Count; ++i)
                    if (bitmaps[i].IsVisible) tempComboBitmaps.Insert(0, bitmaps[i].Image);
                tempComboBitmaps.Insert(0, backGroundPNG);

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
        public void ViewImageUpdata(ListView view)
        {
            List<Bitmap> tempBmp = new List<Bitmap>();
            tempBmp.Add(GraphicsExtension.ImageZoom(backGroundPNG, 35, 35));
            tempBmp.Add(GraphicsExtension.ImageZoom(CurrentBitmap, 35, 35));

            ImageList.Images[Count - Number - 1] = GraphicsExtension.CombineBitmap(ref tempBmp);
            view.Invalidate();
        }
        public void ViewUpdata(ListView view)
        {
            view.Items.Clear();

            ImageList.Images.Clear();
            for (int i = 0; i < Count; i++)
            {
                List<Bitmap> tempBmp = new List<Bitmap>();
                tempBmp.Add(GraphicsExtension.ImageZoom(new Bitmap(backGroundPNG), 35, 35));
                tempBmp.Add(GraphicsExtension.ImageZoom(new Bitmap(bitmaps[Count - i - 1].Image), 35, 35));
                ImageList.Images.Add(GraphicsExtension.CombineBitmap(ref tempBmp));

                ListViewItem tempItem = new ListViewItem(new string[] { "", bitmaps[Count - i - 1].Name });
                tempItem.ImageIndex = ImageList.Images.Count - 1;
                view.Items.Insert(0, tempItem);
            }
            if (Count != 0)
            {
                view.Items[Number].Selected = true;
                view.Select();
            }
        }
        public LayerMemento SaveState()
        {
            List<LayerNode> newBitmaps = new List<LayerNode>();
            foreach(LayerNode bmp in bitmaps)
                newBitmaps.Insert(0, bmp.Clone());

            return new LayerMemento(new Bitmap(backGroundPNG), newBitmaps, ImageList, Number, Size, PanelSize, (Count, nameCount));
        }
        public void RestoreState(LayerMemento layer)
        {
            if (layer == null) return;
            List<LayerNode> newBitmaps = new List<LayerNode>();
            foreach (LayerNode bmp in layer.Bitmaps)
                newBitmaps.Insert(0, bmp.Clone());

            backGroundPNG = layer.BackGroundPNG.Clone() as Bitmap;
            bitmaps = newBitmaps;
            ImageList = layer.Images;
            Number = layer.Number;
            Size = layer.Size;
            PanelSize = layer.PanelSize;
            Count = layer.Counters.Item1;
            nameCount = layer.Counters.Item2;
            base.Resize(Size);

            int x = (PanelSize.Width - Width) / 2;
            x = (x > 0) ? x : 0;
            int y = (PanelSize.Height - Height) / 2;
            y = (y > 0) ? y : 0;
            Bottom.Location = new Point(x, y);
        }
        public void Resize(Size new_size, Size panel_size, ResizeMode mode, Rectangle rect)
        {
            base.Resize(new_size);
            Bottom.Location = new Point((panel_size.Width - Width) / 2, (panel_size.Height - Height) / 2);

            switch (mode)
            {
                case ResizeMode.Compression:
                    for (int i = 0; i < Count; i++)
                        bitmaps[i].Image = new Bitmap(bitmaps[i].Image, new Size(Width, Height));
                    break;
                case ResizeMode.Framing:
                    Size dSize = new Size(Math.Abs(bitmaps[0].Image.Width - Width), Math.Abs(bitmaps[0].Image.Height - Height));
                    if (rect == Rectangle.Empty) rect = new Rectangle(dSize.Width / 2, dSize.Height / 2, Width, Height);
                    for (int i = 0; i < Count; i++)
                    {
                        Bitmap tempBmp;
                        tempBmp = GraphicsExtension.Crop(bitmaps[i].Image, rect);
                        bitmaps[i].Image = tempBmp;
                    }
                    break;
            }

            backGroundPNG = new Bitmap(Width, Height).FillPngBackground();

            Rebuilding();
            Update();
        }
    }
    class LayerMemento
    {
        public Bitmap BackGroundPNG { get; private set; }
        public List<LayerNode> Bitmaps { get; private set; }
        public ImageList Images { get; private set; }
        public (int, int) Counters { get; private set; }
        public int Number { get; private set; }
        public Size Size { get; private set; }
        public Size PanelSize { get; private set; }

        public LayerMemento(Bitmap backGround, List<LayerNode> bitmaps, ImageList images, int number,
            Size size, Size panelSize, (int, int) counters)
        {
            BackGroundPNG = backGround;
            Bitmaps = bitmaps;
            Images = images;
            Number = number;
            Size = size;
            PanelSize = panelSize;
            Counters = counters;
        }
    }
    class LayerHistory
    {
        private List<LayerMemento> history;
        private LayerMemento lastMemento; 

        public delegate void LayerMementoHandler(object sender);
        public event LayerMementoHandler Action;

        public int NumberSave { get; private set; }
        public int Count { get; private set; }
        public LayerHistory()
        {
            history = new List<LayerMemento>();
            NumberSave = -1;
            Count = 0;
        }

        public void Add(LayerMemento memento)
        {
            history.Insert(++NumberSave, memento);
            Count++;
            if(Count > 10)
            {
                history.RemoveAt(0);
                Count--;
            }
            Action?.Invoke(this);
        }
        public void push_end(LayerMemento memento)
        {
            lastMemento = memento;
        }
        public LayerMemento GetPrevSave()
        {         
            if(NumberSave > 0)
            {
                NumberSave--;
                Action?.Invoke(this);
                return history[NumberSave + 1];
            }
            return null;
        }
        public LayerMemento GetNextSave()
        {
            if (NumberSave + 1 < Count - 1)
            {
                NumberSave++;
                Action?.Invoke(this);
                return history[NumberSave];
            }
            else
            {
                NumberSave++;
                Action?.Invoke(this);
                NumberSave--;
                return lastMemento;
            }
            
        }
    }
}
