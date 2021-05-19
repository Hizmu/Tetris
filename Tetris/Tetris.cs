using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            UpdateStyles();

        }

        private void Tetris_Load(object sender, EventArgs e)
        {
            this.scoreTetrisViewTableAdapter.Fill(this.scoreTetrisDataSet.ScoreTetrisView);
            this.DoubleBuffered = true;
            score = new Score(this);
            main = new MainMenu() {Owner = this };
            game = Game.GetInstance(this,score);
            game.Autoplay = true;
            game.Start();
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
