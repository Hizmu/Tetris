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
        public static Dictionary<ColorBlock, Bitmap> standartblocks { get; private set; }
    
        public static void LoadBlocksFromImage()
        {
            LoadImage.standartblocks = new Dictionary<ColorBlock, Bitmap>();
            standartblocks.Add(ColorBlock.Blue,  global::Tetris.Properties.Resources.BlueBlock );
            standartblocks.Add(ColorBlock.Red, global::Tetris.Properties.Resources.RedBlock);
            standartblocks.Add(ColorBlock.Yellow, global::Tetris.Properties.Resources.YellowBlock );
            standartblocks.Add(ColorBlock.Purple, global::Tetris.Properties.Resources.PurpleBlock );
            standartblocks.Add(ColorBlock.Green, global::Tetris.Properties.Resources.GreenBlock );
        }
    }
}
