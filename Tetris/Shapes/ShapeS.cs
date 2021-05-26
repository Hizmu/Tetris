using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ShapeS : Shape
    {
        public ShapeS()
        {
            Width = 3;
            Height = 2;
            Blocks = new int[,]
            {
               { 0, 1, 1 },
               { 1, 1, 0 }
            };
        }
        public override Shape Clone()
        {
            return new ShapeS { Blocks = this.Blocks, Width = this.Width, Height = this.Height, imgBlocks = this.imgBlocks };
        }
    }
}
