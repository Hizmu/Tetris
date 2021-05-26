using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ShapeLl : Shape
    {
        public ShapeLl()
        {

            Width = 2;
            Height = 2;
            Blocks = new int[,]
            {
               { 1,1},
               { 1,0}
            };

        }
        public override Shape Clone()
        {
            return new ShapeLl { Blocks = this.Blocks, Width = this.Width, Height = this.Height, imgBlocks = this.imgBlocks };
        }
    }
}
