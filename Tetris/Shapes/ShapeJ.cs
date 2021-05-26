using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ShapeJ : Shape
    {
        public ShapeJ()
        {
            Width = 3;
            Height = 2;
            Blocks = new int[,]
            {
               { 1, 0, 0 },
               { 1, 1, 1 }
            };

        }
        public override Shape Clone()
        {
            return new ShapeJ{ Blocks = this.Blocks, Width = this.Width, Height = this.Height, imgBlocks = this.imgBlocks };
        }
    }
}
