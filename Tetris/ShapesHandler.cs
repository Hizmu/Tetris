using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// ShapesHandler.cs
namespace Tetris
{
    static class ShapesHandler
    {
        // зберігаються шаблонні фігури
        private static List<Shape> shapesArray = new List<Shape>();
        private static Random random = new Random();
        static ShapesHandler() { }
        public static void AddTemplateShape(Shape shape)
        {
            shapesArray.Add(shape);
        }
        public static Shape GetRandomShape()
        {
 
            Shape shape = shapesArray[random.Next(shapesArray.Count)].Clone();
          
            Image image = LoadImage.standartblocks[((ColorBlock)(random.Next(LoadImage.standartblocks.Count) ))];
            int count = 0;
            foreach(var i in shape.Blocks)
                if (i == 1)
                {
                    count++;
                }

            shape.InitPictureBox(new PictureBox(){ Image = new Bitmap(image), Visible = false, Width = Setting.blockSize, Height = Setting.blockSize }, count);
            return shape;
        }
    }
}
