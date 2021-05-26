using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    // складнісит гри
    enum difficult : int
    {
        ease = 10,
        medium = 20,
        hard = 30,
        impossible = 50,
    }

    /// <summary>
    /// Основні налаштування програми
    /// </summary>
    static class Setting
    {
        // Ширина сітки (кількисть стовпців)
        public static int gridWidth { get { return 15; } }
        // Висота сітки (кількисть рядків)
        public static int gridHeight { get { return 20; } }
        // Розмір блоку (залежить від розміру картинки блоку )
        public static int blockSize { get { return 15; } }
        // Початкова позиції малювання сітки 
        public static int startpositionX { get { return 70; } }
        public static int startpositionY { get { return 70; } }
        // складність гри (швидкість зменшення часу між тіками)
        public static difficult Difficult { get { return difficult.medium; } }
        // початкова швидкість (час мід тіками)
        public static int startSpeed { get { return 1000; } }
        // швидкість при автоматичній грі
        public static int autoGameSpeed { get { return 600; } }
        // Параметри підключення до SQL серверу

        public static string conn_Score = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=ScoreTetris;Integrated Security=True;Pooling=False";
    }
}
