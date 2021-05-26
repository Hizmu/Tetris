using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ShapeO:Shape
    {
        public ShapeO()
        {
            Width = 2;
            Height = 2;
            Blocks = new int[,]
            {
                { 1, 1 },
                { 1, 1 }
            };
        }
        public override Shape Clone()
        {
            return new ShapeO { Blocks = this.Blocks, Width = this.Width, Height = this.Height, imgBlocks = this.imgBlocks };
        }
    }
}
