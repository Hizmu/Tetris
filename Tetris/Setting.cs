using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    enum difficult : int
    {
        ease = 10,
        medium = 20,
        hard = 30,
        impossible = 50,
    }
    static class Setting
    {
        public static int gridWidth { get { return 15; } }
        public static int gridHeight { get { return 20; } }
        public static int blockSize { get { return 15; } }
        public static int startpositionX { get { return 70; } }
        public static int startpositionY { get { return 70; } }
        public static difficult Difficult { get { return difficult.medium; } }
        public static int startSpeed { get { return 1000; } }
        public static int autoGameSpeed { get { return 600; } }

        public static string conn_Score = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Score;Integrated Security=True;Pooling=False";
    }
}
