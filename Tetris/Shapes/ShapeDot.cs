using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ShapeDot : Shape
    {
        public ShapeDot()
        {

            Width = 1;
            Height = 1;
            Blocks = new int[,]
            {
               { 1}
            };
            }
        public override Shape Clone()
        {
            return new ShapeDot { Blocks = this.Blocks, Width = this.Width, Height = this.Height, imgBlocks = this.imgBlocks };
        }
    }
}
