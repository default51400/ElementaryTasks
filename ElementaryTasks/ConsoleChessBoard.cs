using System;

namespace ElementaryTasks
{
    public class ConsoleChessBoard : ChessBoard
    {
        public ConsoleChessBoard(int height, int width) : base(height, width)
        {
        }
        //public ConsoleChessBoard(string[] args) 
        //{

        //}
        public override void ShowChessBoard()
        {
            for (int i = 1; i <= base.Height; i++)
            {
                for (int j = 1; j <= base.Width; j++)
                {
                    if (i % 2 == 1)
                        if (j % 2 == 1) Console.Write(" ");
                        else Console.Write("*");
                    else
                    if (j % 2 == 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void ChessBoardMenu(string[] args)
        {
            switch (args.Length)
            {
                //args.Lenght only = 2, because two-dimensional plane
                case 2:
                    if (ValidatorTwoIntegerNumbers.Validate(args))
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
