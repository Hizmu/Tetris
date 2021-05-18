using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    static class ShapesHandler
    {
        private static Shape[] shapesArray;
        private static Random random = new Random();
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
                    },

                    new Shape {
                        Width = 1,
                        Height = 1,
                        Blocks = new int[,]
                        {
                            { 1}
                        }
                    },
                    new Shape {
                        Width = 2,
                        Height = 2,
                        Blocks = new int[,]
                        {
                            { 1,1},
                            { 1,0}
                        }
                    },
                    new Shape {
                        Width = 1,
                        Height = 2,
                        Blocks = new int[,]
                        {
                            { 1},
                            { 1}
                        }
                    },
                };
        }
        public static Shape GetRandomShape()
        {
            
            Shape shape = new Shape(shapesArray[random.Next(shapesArray.Length)]);
            Image image = LoadImage.standartblocks[((ColorBlock)(random.Next(LoadImage.standartblocks.Count) ))];
            foreach(var i in shape.Blocks)
                if (i == 1)
                {
                    shape.count++;
                }

            shape.InitPictureBox(new PictureBox(){ Image = new Bitmap(image), Visible = false, Width = Setting.blockSize, Height = Setting.blockSize });
            return shape;
        }
    }
}
