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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Focus();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Tetris.Nickname = tbName.Text;
            Invalidate();
        }
        public void BTRefresh()
        {
            this.btExit.Refresh();
            this.btStart.Refresh();
            this.btScore.Refresh();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Key = e.KeyChar;
            if ((Key < 'A' || Key > 'Z') && (Key < 'a' || Key > 'z') && (Key < '0' || Key > '9') && Key != '_' && Key != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

    }
}
