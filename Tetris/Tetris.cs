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
        }

        private void Tetris_Load(object sender, EventArgs e)
        {
            this.scoreTetrisViewTableAdapter.Fill(this.scoreTetrisDataSet.ScoreTetrisView);

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
            switch (main.ShowDialog())
            {
                case DialogResult.OK:
                    main.Hide();
                    game.Autoplay = false;
                    game.Restart();
                    return;
                case DialogResult.Abort:
                    Application.Exit();
                    return;
                case DialogResult.Cancel:
                    main.Hide();
                    this.scoreTetrisViewTableAdapter.Fill(this.scoreTetrisDataSet.ScoreTetrisView);
                    score.ShowScore();
                    break;


            }
        }

        private void btCloseScore_Click(object sender, EventArgs e)
        {
            score.HideScore();
            Main();
        }

    }
}
