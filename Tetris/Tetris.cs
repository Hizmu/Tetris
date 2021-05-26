using System;
using System.Windows.Forms;

// Tetris.cs
namespace Tetris
{
    public partial class Tetris : Form
    {
        Game game;
        Score score;
        public static string Nickname;
        MainMenu main;
        public Tetris()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.AllPaintingInWmPaint 
                | ControlStyles.UserPaint, true);
            this.DoubleBuffered = true;
            UpdateStyles();
            InitShapes();
        }

        private void Tetris_Load(object sender, EventArgs e)
        {

            score = new Score(this);
            main = new MainMenu() {Owner = this };
            game = Game.getInstance(this,score);
            game.Autoplay = true;
            game.Start();
        }
        private void InitShapes()
        {
            ShapesHandler.AddTemplateShape(new ShapeI());
            ShapesHandler.AddTemplateShape(new ShapeO());
            ShapesHandler.AddTemplateShape(new ShapeJ());
            ShapesHandler.AddTemplateShape(new ShapeL());
            ShapesHandler.AddTemplateShape(new ShapeZ());
            ShapesHandler.AddTemplateShape(new ShapeS());
            ShapesHandler.AddTemplateShape(new ShapeDot());
            ShapesHandler.AddTemplateShape(new Shapeil());
            ShapesHandler.AddTemplateShape(new ShapeLl());
        }
        private void Tetris_Shown(object sender, EventArgs e)
        {
            Main();
        }
        public void Main()
        {
            timer.Start();
            score.HideScore();
            main.Refresh();
            switch (main.ShowDialog())
            {
                case DialogResult.OK:
                    main.Update();
                    game.Autoplay = false;
                    game.Restart();
                    main.Hide();
                    this.Focus();
                    return;
                case DialogResult.Abort:
                    Application.Exit();
                    return;
                case DialogResult.Cancel:
                    main.Hide();
                    this.scoreTetrisViewTableAdapter.Fill(this.scoreTetrisDataSet.ScoreTetrisView);
                    score.ShowScore();
                    return;


            }
        }

        private void btCloseScore_Click(object sender, EventArgs e)
        {
            score.HideScore();
            Main();
        }

        private void Tetris_Paint(object sender, PaintEventArgs e)
        {
            game.DrawGrid(e.Graphics);
        }
    }
}
