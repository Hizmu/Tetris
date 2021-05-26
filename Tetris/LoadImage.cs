using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    enum ColorBlock
    {
        Red,
        Green,
        Blue,
        Yellow,
        Purple
    }
    static class LoadImage
    {
        public static Dictionary<ColorBlock, Image> standartblocks { get; private set; }

        // Завантаження зображення
        public static void LoadBlocksFromImage()
        {
            LoadImage.standartblocks = new Dictionary<ColorBlock, Image>();
            standartblocks.Add(ColorBlock.Blue,  Resource.BlueBlock );
            standartblocks.Add(ColorBlock.Red, Resource.RedBlock);
            standartblocks.Add(ColorBlock.Yellow, Resource.YellowBlock );
            standartblocks.Add(ColorBlock.Purple, Resource.PurpleBlock );
            standartblocks.Add(ColorBlock.Green, Resource.GreenBlock );
        }
    }
}
