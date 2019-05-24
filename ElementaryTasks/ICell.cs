using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    interface ICell
    {
        bool IsDark { get; }
        int Heigth { get; }
        int Width { get; }
        //Point gorizontalX
        //Point verticalY
    }
}
