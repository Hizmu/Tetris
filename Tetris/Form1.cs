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
        public Tetris()
        {
            InitializeComponent();




        }

        private void Tetris_Load(object sender, EventArgs e)
        {
            game = Game.GetInstance(this);

            game.Start();
        }

        private void Tetris_Shown(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
