using System.Drawing;
using System.Windows.Forms;

// Shape.cs
namespace Tetris
{
    abstract class Shape
    {

        // Розмір масиву Blocks
        public int Width { get; set; }
        public int Height { get; set; }
        public int[,] Blocks { get; set; }

        // Малюнки які буду переміщуватись
        public PictureBox [] imgBlocks { get; set; }

        private int[,] backupBlocks { get; set; }

        public Shape() { }
        public Shape(Shape shape)
        {
            this.Width = shape.Width;
            this.Height = shape.Height;
            this.Blocks = shape.Blocks;
        }
        abstract public Shape Clone();

        public void InitPictureBox(PictureBox picture,int count)
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
        public void Turn()
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
        public void Rollback()
        {
            Blocks = backupBlocks;

            var temp = Width;
            Width = Height;
            Height = temp;
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

    }
}
