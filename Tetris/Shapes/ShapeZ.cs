using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ShapeZ : Shape
    {
        public ShapeZ()
        {

            Width = 3;
            Height = 2;
            Blocks = new int[,]
            {
                { 1, 1, 0 },
                { 0, 1, 1 }
            };
        }
        public override Shape Clone()
        {
            return new ShapeZ { Blocks = this.Blocks, Width = this.Width, Height = this.Height, imgBlocks = this.imgBlocks };
        }
    }
}
