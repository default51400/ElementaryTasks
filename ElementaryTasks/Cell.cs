using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    class Cell : ICell
    {
        public int Heigth { get; private set; }
        public int Width { get; private set; }
        public bool IsDark { get; private set; }

        public Cell(int heigth, int width, bool isDark)
        {
            this.Heigth = heigth;
            this.Width = width;
            this.IsDark = isDark;
        }

    }
}
