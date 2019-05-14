using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    class ConsoleChessBoard : ChessBoard
    {
        public ConsoleChessBoard(int height, int width) : base(height,width)
        {
        }

        public void newConsoleChessBoard(string[] args)
        {
        }
        public override void ShowChessBoard()
        {
            for (int i = 1; i <= base.Height; i++)
            {
                for (int y = 1; y <= base.Width; y++)
                {
                    if(i%2 == 1)
                        Console.Write("* ");
                    else
                        Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        public void ChessBoardMenu(string[] args)
        {
            switch (args.Length)
            {
                case 2:
                    if (int.TryParse(args[0], out int width) && int.TryParse(args[1], out int height))
                    {
                        //Validate(width);
                        //Validate(height);

                    }
                    else
                    {
                        //ShowInstruction();
                    }
                    break;

                default: //ShowInstruction();
                    break;
            }
        }
    }
}
