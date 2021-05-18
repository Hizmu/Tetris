
using System.Windows.Forms;

namespace Tetris
{
    class Cell
    {
        public int num { get; set; }
        public PictureBox image { get; set; }
        public static bool operator ==(Cell cell, int i)
        {
            return cell.num == i;
        }
        public static bool operator !=(Cell cell, int i)
        {
            return cell.num != i;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
