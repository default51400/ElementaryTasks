using System;
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
            ConsoleManager consoleManager = new ConsoleManager(args);
            IDraw consoleUI = new ConsoleUI();
            consoleUI.Draw(consoleManager.Board);
        }
    }

}
