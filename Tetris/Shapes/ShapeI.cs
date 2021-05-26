using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ShapeI : Shape
    {
        public ShapeI()
        {
            Width = 1;
            Height = 4;
            Blocks = new int[,]
            {
              { 1 },
              { 1 },
              { 1 },
              { 1 }
            };
        }
        public override Shape Clone()
        {
            return new ShapeI{ Blocks = this.Blocks, Width = this.Width, Height = this.Height, imgBlocks = this.imgBlocks };
        }
    }
}
