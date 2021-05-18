using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{

    class Game
    {
        int currentX = 0;
        int currentY = 0;
        int gridWidth = Setting.gridWidth;
        int gridHeight = Setting.gridHeight;
        Cell[,] grid = null;
        Shape currentShape  = null;
        Shape nextShape = null;
        private static Game game;
        private static Tetris tetris;
        private static Score score;
        public bool Autoplay { get; set; }
        private Game()
        {
            grid = new Cell[gridWidth, gridHeight];
            for (int i = 0; i < gridWidth; i++)
                for (int j = 0; j < gridHeight; j++)
                    grid[i, j] = new Cell();
            LoadImage.LoadBlocksFromImage();
        }

        public void Start()
        {
            tetris.timer.Tick += game.Time_Tick;
            if (Autoplay)
                tetris.timer.Interval = Setting.autoGameSpeed;
            else
            {
                tetris.timer.Interval = Setting.startSpeed;
            }
            tetris.KeyDown += game.Key_Down;
            currentShape = getRandomShapeCenter();
            nextShape = getNextShape();
            currentShape.AddToControls(tetris);
        }
        public void Restart()
        {
            tetris.timer.Stop();
            currentShape.RemoveFromControl(tetris);
            nextShape.RemoveFromControl(tetris);
            ClearGrid();

            currentShape = getRandomShapeCenter();
            nextShape = getNextShape();
            currentShape.AddToControls(tetris);
            tetris.timer.Start();
        }
        private void ClearGrid()
        {
            for (int i = 0; i < gridWidth; i++)
                for (int j = 0; j < gridHeight; j++) {
                    grid[i, j].num = 0;
                    if (grid[i, j].image != null)
                    {
                        tetris.Controls.Remove(grid[i, j].image);
                        grid[i, j].image = null;
                    }
                }
        }
        public void Time_Tick(object sender, EventArgs e)
        {
            if (!moveShapeIfPossible(moveDown: 1))
            {
                nextShape.Hide();
                updateGridWithCurrentShape();
                currentShape = nextShape;
                nextShape = getNextShape();
                clearFilledRowsAndUpdateScore();

            }
        }
        public static Game GetInstance(Tetris tetris,Score score)
        {
            if (game == null)
            {
                game = new Game();
                Game.score = score;
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
                    {
                        return false;
                    }
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
                        currentShape.imgBlocks[k].Location = new Point(Setting.startpositionX + (currentX + i) * Setting.blockSize, Setting.startpositionY +(currentY + j) * Setting.blockSize);
                        if (currentShape.imgBlocks[k].Location.Y >= 0)
                        {
                            currentShape.imgBlocks[k].Visible = true;
                        }
                        k++;
                    }
                }
            }
        }
        private void updateGridWithCurrentShape()
        {
            int k = 0;
            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (currentShape.Blocks[j, i] == 1)
                    {
                        if (checkIfGameOver())
                            return;
                        grid[currentX + i, currentY + j].num = 1;
                        grid[currentX + i, currentY + j].image = currentShape.imgBlocks[k];
                        k++;
                    }
                }
            }
        }
        private bool checkIfGameOver()
        {
            if (currentY <= -1)
            {
                tetris.timer.Stop();
                if (Autoplay == false)
                {
                    MessageBox.Show(tetris,"Game Over");
                    Autoplay = true;
               //     score.PushScore();
                    Restart();
                    tetris.Main();
                }
                else
                {
                    this.Restart();
                }
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
                case Keys.Escape:
                    tetris.timer.Stop();
                    Pause();
                    tetris.Opacity = 1;
                    return;
            }
            if (!moveShapeIfPossible(horizontalMove, verticalMove) && (e.KeyCode == Keys.Up || e.KeyCode == Keys.Space || e.KeyCode == Keys.W))
            {
                currentShape.rollback();
            }
        }
        public void Pause()
        {
            PauseMenu pauseMenu = new PauseMenu();
            tetris.Opacity = .80;
            switch(pauseMenu.ShowDialog())
            {
                case DialogResult.OK:
                    tetris.timer.Start();
                    return;
                case DialogResult.Cancel:
                    Application.Exit();
                    return;             
                case DialogResult.Abort:
                    Application.Exit();
                    return;

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
                    tetris.lbLevel.Text = "Level: " + score.score / 100;

                    tetris.timer.Interval -= (int)Setting.Difficult;

                    for (j = 0; j < gridWidth; j++)
                    {
                        grid[j, i].image.Dispose();
                    }
                    for (j = 0; j < gridWidth; j++)
                    {
                        for (int k = i; k > 0; k--)
                        {

                            grid[j, k] = grid[j, k - 1];
                            if(grid[j,k].image != null)
                            grid[j, k].image.Location = new Point(Setting.startpositionX + j * Setting.blockSize, Setting.startpositionY + k * Setting.blockSize);
                        }

                        grid[j, 0].num = 0;
                    }
                }
            }

        }
        private Shape getRandomShapeCenter()
        {
            var shape = ShapesHandler.GetRandomShape();
            currentX = (int)Math.Floor((double)gridWidth/2.0f);
            if(currentShape == null)
            currentY = -shape.Height;
                else
            currentY = -currentShape.Height;
            return shape;
        }

        public Shape getNextShape()
        {
            int k = 0;
            var shape = getRandomShapeCenter();
            for (int i = 0; i < shape.Width; i++)
            {
                for (int j = 0; j < shape.Height; j++)
                {
                    if (shape.Blocks[j, i] == 1)
                    {
                        shape.imgBlocks[k].Location = new Point( tetris.lbNext.Location.X + Setting.blockSize * i, Setting.blockSize + tetris.lbNext.Location.Y + Setting.blockSize * j);

                        k++;
                    }
                    
                }
            }
            shape.Show();
            shape.AddToControls(tetris);
            return shape;
        }

    }
}

