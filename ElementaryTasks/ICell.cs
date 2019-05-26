using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    public interface ICell
    {
        bool IsDark { get; }
        int Height { get; }
        int Width { get; }

        //Point gorizontalX
        //Point verticalY
    }
}
