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
            args[0] = "-1";
            args[1] = "3";
            ConsoleUI chessBoard1 = new ConsoleUI(args);
            
        }
    }

}
