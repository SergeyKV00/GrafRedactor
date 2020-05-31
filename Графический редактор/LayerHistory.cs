using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Графический_редактор
{
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
        private int currentSave;
        private const int Limit = 10;
        private List<LayerMemento> history;

        public delegate void ActionHandler(object sender);
        public event ActionHandler Action;

        public int Count { get => history.Count; }
        public bool Lock { get; private set; }
        public int NumberSave { get => currentSave; set => currentSave = value; }

        public LayerHistory()
        {
            history = new List<LayerMemento>();
            currentSave = 0;
            Lock = false;
        }

        public void Add(LayerMemento memento)
        {
            while(currentSave + 1 < Count)
            {
                history.RemoveAt(Count - 1);
            }

            if (Lock)
                history.RemoveAt(Count - 1);

            history.Add(memento);
            currentSave = Count - 1;

            if(Count > Limit)
            {
                history.RemoveAt(0);
                currentSave--;
            }
            Lock = false;
            Action?.Invoke(this);
        }

        public LayerMemento GetPrevSave()
        {
            currentSave--;
            Action?.Invoke(this);
            if (currentSave > 0)
                return history[currentSave];
            if (Count == 0)
                return null;
            return history[0];
        }

        public LayerMemento GetNextSave()
        {
            currentSave++;
            Lock = true;
            Action?.Invoke(this);
            if (Count == 0)
                return null;
            if (currentSave < Count)
                return history[currentSave];
            return history[Count - 1];
        }
        
    }
}
