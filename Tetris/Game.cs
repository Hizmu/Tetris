using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class Cell
    {
        Cell(int pointX, int pointY)
        {
            this.pointX = pointX;
            this.pointY = pointY;
        }
        public int pointX {get;set;}
        public int pointY {get;set;}
        public PictureBox image { get; set; }
    }
    class Game
    {
        int currentX;
        int currentY;
        int gridWidth = Setting.gridWidth;
        int gridHeight = Setting.gridHeight;
        int score;
        int[,] grid;
  //      Cell grid[,];
        Shape currentShape;
        Shape nextShape;
        private static Game game;
        private static Tetris tetris;

        private Game()
        {
            grid = new int[gridWidth, gridHeight];
            LoadImage.LoadBlocksFromImage();
        }
        public void Start()
        {

            tetris.timer.Tick += game.Time_Tick;
            tetris.timer.Interval = 1000;
            tetris.KeyDown += game.Key_Down;
            currentShape = getRandomShapeCenter();
            nextShape = getNextShape();
            InitRandomShape();

        }
        public void Time_Tick(object sender, EventArgs e)
        {
            if (!moveShapeIfPossible(moveDown: 1))
            {
                updateCanvasDotArrayWithCurrentShape();
                currentShape = nextShape;
                nextShape = getNextShape();
                clearFilledRowsAndUpdateScore();
                InitRandomShape();
            }
        }
        public static Game GetInstance(Tetris tetris)
        {
            if (game == null)
            {
                game = new Game();
                Game.tetris = tetris;

            }

            return game;
        }

        private bool moveShapeIfPossible(int moveDown = 0, int moveSide = 0)
        {
            var newX = currentX + moveSide;
            var newY = currentY + moveDown;

            if (newX < 0 || newX + currentShape.Width > gridWidth
                || newY + currentShape.Height > gridHeight)
                return false;

            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (newY + j > 0 && grid[newX + i, newY + j] == 1 && currentShape.Blocks[j, i] == 1)
                        return false;
                }
            }

            currentX = newX;
            currentY = newY;

            drawShape();

            return true;
        }

        public void drawShape()
        {
            int k = 0;
            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (currentShape.Blocks[j, i] == 1)
                    {
                        currentShape.imgBlocks[k].Location = new Point((currentX + i) * Setting.blockSize, (currentY + j) * Setting.blockSize);
                        if (currentShape.imgBlocks[k].Location.Y >= 0)
                        {
                            currentShape.imgBlocks[k].Visible = true;
                        }
                        k++;
                    }
                }
            }
        }
        public void InitRandomShape()
        {
            foreach (var imgblock in currentShape.imgBlocks)
            {
                tetris.Controls.Add(imgblock);
            }
        }
        private void updateCanvasDotArrayWithCurrentShape()
        {
            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (currentShape.Blocks[j, i] == 1)
                    {
                        if (checkIfGameOver())
                            return;
                        grid[currentX + i, currentY + j] = 1;
                    }
                }
            }
        }
        private bool checkIfGameOver()
        {
            if (currentY < 0)
            {
                tetris.timer.Stop();
                MessageBox.Show("Game Over");
                Application.Exit();
                return true;
            }
            return false;
        }
        public void Key_Down(object sender, KeyEventArgs e)
        {
            var verticalMove = 0;
            var horizontalMove = 0;
            switch (e.KeyCode)
            {
                case Keys.A:
                case Keys.Left:
                    verticalMove--;
                    break;
                case Keys.D:
                case Keys.Right:
                    verticalMove++;
                    break;
                case Keys.S:
                case Keys.Down:
                    horizontalMove++;
                    break;
                case Keys.W:
                case Keys.Space:
                case Keys.Up:
                    currentShape.turn();
                    break;
            }
            if (!moveShapeIfPossible(horizontalMove, verticalMove) && (e.KeyCode == Keys.Up || e.KeyCode == Keys.Space || e.KeyCode == Keys.W))
            {
                currentShape.rollback();
            }
        }

        public void clearFilledRowsAndUpdateScore()
        {
            for (int i = 0; i < gridHeight; i++)
            {
                int j;
                for (j = gridWidth - 1; j >= 0; j--)
                {
                    if (grid[j, i] == 0)
                        break;
                }

                if (j == -1)
                {

                    score += 100;
                    tetris.lbScore.Text = "Score: " + score;
                    tetris.lbLevel.Text = "Level: " + score / 1000;

                    tetris.timer.Interval -= 10;


                    for (j = 0; j < gridWidth; j++)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            grid[j, k] = grid[j, k - 1];
                            if()
                        }

                        grid[j, 0] = 0;
                    }

                }

            }
            for (int i = 0; i < gridWidth; i++)
            {
                for (int j = 0; j < gridHeight; j++)
                {
                    
                }
            }

        }
        private Shape getRandomShapeCenter()
        {
            var shape = ShapesHandler.GetRandomShape();
            currentX = 5;
            currentY = -shape.Height;
            foreach(var imgblock in shape.imgBlocks)
            {
                this.pictureBoxes.Add(imgblock);
            }
            return shape;
        }
        public Shape getNextShape()
        {
            return getRandomShapeCenter();
        }

    }
}

