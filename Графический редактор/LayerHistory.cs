using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
       // Полностью переделать
    }
}
