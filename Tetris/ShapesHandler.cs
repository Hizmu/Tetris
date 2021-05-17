using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    static class ShapesHandler
    {
        private static Shape[] shapesArray;
        static ShapesHandler()
        {
            shapesArray = new Shape[]
                {
                    new Shape {
                        Width = 2,
                        Height = 2,
                        Blocks = new int[,]
                        {
                            { 1, 1 },
                            { 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 1,
                        Height = 4,
                        Blocks = new int[,]
                        {
                            { 1 },
                            { 1 },
                            { 1 },
                            { 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Blocks = new int[,]
                        {
                            { 0, 1, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Blocks = new int[,]
                        {
                            { 0, 0, 1 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Blocks = new int[,]
                        {
                            { 1, 0, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Blocks = new int[,]
                        {
                            { 1, 1, 0 },
                            { 0, 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Blocks = new int[,]
                        {
                            { 0, 1, 1 },
                            { 1, 1, 0 }
                        }
                    }
                };
        }
        public static Shape GetRandomShape()
        {
            Shape shape = new Shape(shapesArray[new Random().Next(shapesArray.Length)]);
            Image image = LoadImage.standartblocks[(ColorBlock)new Random().Next((int)ColorBlock.Purple)];
            for (int i = 0; i < shape.Height; i++)
                for (int j = 0; j < shape.Width; j++)
                {
                    if (shape.Blocks[i, j] == 1)
                    {
                        shape.count++;
                    }
                }
            shape.imgBlocks = new PictureBox[shape.count];
            for (int i = 0; i < shape.count; i++)
            {
                shape.imgBlocks[i] = new PictureBox() { Image = new Bitmap(image),Visible = false,Width = Setting.blockSize, Height = Setting.blockSize };
            }
            return shape;
        }
    }
}
