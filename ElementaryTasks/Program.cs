﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard ch = new ConsoleChessBoard(args);
            ch.ShowChessBoard();
        }
    }

}
