using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class Shape
    {
        public Shape(){}
        public Shape(Shape shape) 
        {
            this.Width = shape.Width;
            this.Height = shape.Height;
            this.count = count;
            this.Blocks = shape.Blocks;
        }
        public int Width { get; set; }
        public int Height { get; set; }

        public PictureBox [] imgBlocks { get; set; }
        public int count { get; set; }
        public int[,] Blocks{ get; set; }
        private int[,] backupBlocks { get; set; }
        public void InitPictureBox(PictureBox picture)
        {
            if (count == 0 || picture == null || picture.Image == null)
                return;

            imgBlocks = new PictureBox[count];
            for (int i = 0; i < imgBlocks.Length; i++)
            {
                imgBlocks[i] = new PictureBox() { Image = new Bitmap(picture.Image), Visible = picture.Visible, Width = picture.Width, Height = picture.Height };
            }
            picture.Dispose();
        }
        public void Hide()
        {
            foreach (var image in imgBlocks)
            {
                image.Visible = false;
            }
        }
        public void Show()
        {
            foreach (var image in imgBlocks)
            {
                image.Visible = true;
            }
        }
        public void AddToControls(Tetris tetris)
        {
            foreach (var image in imgBlocks)
            {
                tetris.Controls.Add(image);
            }
        }
        public void RemoveFromControl(Tetris tetris)
        {
            foreach (var image in imgBlocks)
            {
                tetris.Controls.Remove(image);
            }
        }
        public void turn()
        {

            backupBlocks = Blocks;

            Blocks = new int[Width, Height];

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Blocks[i, j] = backupBlocks[Height - 1 - j, i];
                }
            }

            var temp = Width;
            Width = Height;
            Height = temp;
        }
        public void rollback()
        {
            Blocks = backupBlocks;

            var temp = Width;
            Width = Height;
            Height = temp;
        }
    }
}
